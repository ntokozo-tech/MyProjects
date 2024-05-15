package com.example.charitydonationapp;

import static android.Manifest.permission.READ_EXTERNAL_STORAGE;
import static android.Manifest.permission.WRITE_EXTERNAL_STORAGE;

import android.content.Intent;
import android.graphics.drawable.Drawable;
import android.os.Build;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.GridLayout;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.example.charitydonationapp.classes.FileHandler;
import com.example.charitydonationapp.classes.Organization;
import com.example.charitydonationapp.classes.RegisterOrg;
import com.example.charitydonationapp.classes.Status;
import com.example.charitydonationapp.classes.User;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class MainActivity2 extends AppCompatActivity {
     private TextView txtMessage;
    private TextView txtSelectOrg;
    private List<Button> buttons = new ArrayList<>();
    private EditText txtAmount;
    private ImageView right_icon, left_icon;
    private Button btnDonate;
    private User user;
    private Map<Integer, RegisterOrg> map = new HashMap<>();
    private BigDecimal tax;
    private Map<Integer, List<Organization>> donationMap = new HashMap<>();
    private List<Organization> organizations = new ArrayList<>();
    private String orgName;
    private int orgCd;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main2);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.M)
        {
            requestPermissions(new String[] {WRITE_EXTERNAL_STORAGE, READ_EXTERNAL_STORAGE}, 1);
        }
        left_icon = findViewById(R.id.left_icon);
        right_icon = findViewById(R.id.right_icon);
        btnDonate = findViewById(R.id.btnDonate);
        txtAmount = findViewById(R.id.txtAmount);
        txtMessage = findViewById(R.id.txtMessage);
        txtSelectOrg = findViewById(R.id.txtSelectOrg);

        InputStream is  = null;
        try {
            is = getAssets().open("organization.txt");
        } catch (IOException e) {
            e.printStackTrace();
        }
       organizations = FileHandler.loadOrganisations(is);
        user = (User) getIntent().getSerializableExtra("user");

        left_icon.setOnClickListener(e->{
            Intent intent = new Intent(this, MainActivity.class);
            startActivity(intent);
        });
        right_icon.setOnClickListener(e->{
            Intent intent = new Intent(this, MainActivity3.class);
            intent.putExtra("user", user);
            startActivity(intent);
        });
        GridLayout gridLayout = findViewById(R.id.grid);
        FileInputStream fis = null;
        try {
            fis = openFileInput("organization_registration.bin");
            map = FileHandler.readRegOrgMapFromFile(fis);

            for (Map.Entry<Integer, RegisterOrg> entry : map.entrySet())
            {
                if (entry.getValue().getAppStatus().equals(Status.APPROVED.name()))
                {
                   Button button = new Button(this);
                   button.setText(entry.getValue().getOrganization().getOrgName());
                   gridLayout.addView(button);
                   button.setOnClickListener(e->{
                       orgName = entry.getValue().getOrganization().getOrgName();
                       orgCd = entry.getValue().getOrganization().getOrgCd();
                       txtSelectOrg.setText("Donate to: " + orgName + " public benefit organisation");
                   });
                }
            }

        } catch (FileNotFoundException e) {
            throw new RuntimeException(e);
        } catch (IOException e) {
            throw new RuntimeException(e);
        } catch (ClassNotFoundException e) {
            throw new RuntimeException(e);
        }


        //txtMessage.setText("Hi " + user.getUsername() + ", your tax reduction: " + tax);
        btnDonate.setOnClickListener(e->{
            if(orgName != null && !txtAmount.getText().toString().isEmpty())
            {
                try {
                    //writeMapToFile(donationMap);
                    calculateReduction();
                } catch (IOException ex) {
                    ex.printStackTrace();
                } catch (ClassNotFoundException ex) {
                    ex.printStackTrace();
                }
            }
            else
            {
                Toast.makeText(this, "Please select organization, and fill in the amount to donate", Toast.LENGTH_SHORT).show();
            }
        });
    }
    private BigDecimal calculateReduction() throws IOException, ClassNotFoundException
    {
        BigDecimal totalReduction = BigDecimal.ZERO;
        BigDecimal donatedAmount = BigDecimal.valueOf(Double.parseDouble(txtAmount.getText().toString()));
        FileInputStream fis = openFileInput("charity_donation4.bin");
        donationMap = FileHandler.readMapFromFile(fis);

        if(donationMap != null)
        {
           List<Organization> list = donationMap.get(user.getUserCd());
            totalReduction = donatedAmount.multiply(BigDecimal.valueOf(user.getMarginRate())).divide(BigDecimal.valueOf(100), 4, RoundingMode.HALF_UP);
            BigDecimal bracket = determinetaxBracket();
            BigDecimal taxReduc = totalReduction.divide(bracket, 4, RoundingMode.HALF_UP).multiply(tax);
            BigDecimal rate = tax.subtract(taxReduc);
            if(taxReduc.compareTo(tax) < 0)
            {
                txtMessage.setText("Hey " + user.getUsername() + ", your tax reduction: " + tax.subtract(taxReduc) + "%");

            }else{
                txtMessage.setText("Hey " + user.getUsername() + ", your tax reduction: " + 0 + "%");
            }

            if(list != null)
            {
                donationMap.get(user.getUserCd()).add(new Organization(orgCd, orgName, BigDecimal.valueOf(Double.parseDouble(txtAmount.getText().toString())),
                        rate));
            }
            else
            {
                List<Organization> organizationList = new ArrayList<>();
                organizationList.add(new Organization(orgCd, orgName,BigDecimal.valueOf(Double.parseDouble(txtAmount.getText().toString()))
                ,rate));
                if (donationMap.get(user.getUserCd()) == null)
                {
                    donationMap.put(user.getUserCd(), organizationList);
                }
            }
        }
        FileOutputStream fos = openFileOutput("charity_donation4.bin", MODE_PRIVATE);
        FileHandler.writeMapToFile(donationMap,fos);
        return totalReduction;
    }

    private BigDecimal determinetaxBracket()
    {
        int less = user.getAmount().compareTo(BigDecimal.valueOf(237000));
        int greater = user.getAmount().compareTo(BigDecimal.valueOf(1));

        if(less < 0 && greater > 0)
        {
            //18%
            tax = BigDecimal.valueOf(18);
            return  user.getAmount().multiply(BigDecimal.valueOf(18)).divide(BigDecimal.valueOf(100), 4, RoundingMode.HALF_UP);
        }

         less = user.getAmount().compareTo(BigDecimal.valueOf(370500));
         greater = user.getAmount().compareTo(BigDecimal.valueOf(237101));
        if(less < 0 && greater > 0)
        {
            //26%
            tax = BigDecimal.valueOf(26);
            return  user.getAmount().multiply(BigDecimal.valueOf(26)).divide(BigDecimal.valueOf(100), 4, RoundingMode.HALF_UP);
        }
        less = user.getAmount().compareTo(BigDecimal.valueOf(512800));
        greater = user.getAmount().compareTo(BigDecimal.valueOf(370501));
        if(less < 0 && greater > 0)
        {
            //31%
            tax = BigDecimal.valueOf(31);
            return  user.getAmount().multiply(BigDecimal.valueOf(31)).divide(BigDecimal.valueOf(100), 4, RoundingMode.HALF_UP);
        }
        less = user.getAmount().compareTo(BigDecimal.valueOf(673000));
        greater = user.getAmount().compareTo(BigDecimal.valueOf(512801));
        if(less < 0 && greater > 0)
        {
            //36%
            tax = BigDecimal.valueOf(36);
            return  user.getAmount().multiply(BigDecimal.valueOf(36)).divide(BigDecimal.valueOf(100), 4, RoundingMode.HALF_UP);
        }
        less = user.getAmount().compareTo(BigDecimal.valueOf(857900));
        greater = user.getAmount().compareTo(BigDecimal.valueOf(673001));
        if(less < 0 && greater > 0)
        {
            //39%
            tax = BigDecimal.valueOf(39);
            return  user.getAmount().multiply(BigDecimal.valueOf(39)).divide(BigDecimal.valueOf(100), 4, RoundingMode.HALF_UP);
        }
        less = user.getAmount().compareTo(BigDecimal.valueOf(1817000));
        greater = user.getAmount().compareTo(BigDecimal.valueOf(857901));
        if(less < 0 && greater > 0)
        {
            //41%
            tax = BigDecimal.valueOf(41);
            return  user.getAmount().multiply(BigDecimal.valueOf(41)).divide(BigDecimal.valueOf(100), 4, RoundingMode.HALF_UP);
        }
        greater = user.getAmount().compareTo(BigDecimal.valueOf(1817001));
        if(greater > 0)
        {
            //45%
            tax = BigDecimal.valueOf(45);
            return  user.getAmount().multiply(BigDecimal.valueOf(45)).divide(BigDecimal.valueOf(100), 4, RoundingMode.HALF_UP);
        }
        return  BigDecimal.ZERO;
    }
}