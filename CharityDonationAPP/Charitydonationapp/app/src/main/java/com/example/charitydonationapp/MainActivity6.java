package com.example.charitydonationapp;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.cardview.widget.CardView;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.example.charitydonationapp.classes.FileHandler;
import com.example.charitydonationapp.classes.Organization;
import com.example.charitydonationapp.classes.RegisterOrg;
import com.example.charitydonationapp.classes.Status;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class MainActivity6 extends AppCompatActivity {
    private Button btnApprove, btnDecline;
    private TextView tvDetails,tvLogin;
    private  Map<Integer, RegisterOrg> map = null;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main6);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        btnApprove = findViewById(R.id.btnApprove);
        btnDecline = findViewById(R.id.btnDecline);
        tvDetails = findViewById(R.id.tvDetails);
        tvLogin = findViewById(R.id.tvLogin);

        tvLogin.setOnClickListener(e->{
            Intent intent = new Intent(this, MainActivity.class);
            startActivity(intent);
        });
        try {
            FileInputStream fis = openFileInput("organization_registration.bin");
           map = FileHandler.readRegOrgMapFromFile(fis);
        } catch (FileNotFoundException e) {
            throw new RuntimeException(e);
        } catch (IOException e) {
            throw new RuntimeException(e);
        } catch (ClassNotFoundException e) {
            throw new RuntimeException(e);
        }

        if(map != null)
        {
            for (Map.Entry<Integer, RegisterOrg> entry : map.entrySet())
            {
                if (entry.getValue().getAppStatus().equals(Status.PENDING.name()))
                {
                    tvDetails.setText("Org Name: "+entry.getValue().getOrganization().getOrgName() + "\nOrg Registration: " + entry.getValue().getOrgRegNum()
                    + "\nPBO num: " + entry.getValue().getPboNum());
                    break;
                }
            }
        }
        btnApprove.setOnClickListener(e->{
            if(map != null)
            {
                for (Map.Entry<Integer, RegisterOrg> entry : map.entrySet())
                {
                    if (entry.getValue().getAppStatus().equals(Status.PENDING.name()))
                    {
                        map.get(entry.getValue().getRegCd()).setAppStatus(Status.APPROVED.name());
                        FileOutputStream fos = null;
                        try {
                            fos = openFileOutput("organization_registration.bin", MODE_PRIVATE);
                            FileHandler.writeMapToFile1(map, fos);
                        } catch (FileNotFoundException ex) {
                            throw new RuntimeException(ex);
                        } catch (IOException ex) {
                            throw new RuntimeException(ex);
                        } catch (ClassNotFoundException ex) {
                            throw new RuntimeException(ex);
                        }
                        break;
                    }
                }
                for (Map.Entry<Integer, RegisterOrg> entry : map.entrySet())
                {
                    if (entry.getValue().getAppStatus().equals(Status.PENDING.name()))
                    {
                        tvDetails.setText("Org Name: "+entry.getValue().getOrganization().getOrgName() + "\nOrg Registration: " + entry.getValue().getOrgRegNum()
                                + "\nOrg PBO num: " + entry.getValue().getPboNum());
                        break;
                    }
                }
            }
        });

        btnDecline.setOnClickListener(e->{
            if(map != null)
            {
                for (Map.Entry<Integer, RegisterOrg> entry : map.entrySet())
                {
                    if (entry.getValue().getAppStatus().equals(Status.PENDING.name()))
                    {
                        map.get(entry.getValue().getRegCd()).setAppStatus(Status.DECLINED.name());
                        FileOutputStream fos = null;
                        try {
                            fos = openFileOutput("organization_registration.bin", MODE_PRIVATE);
                            FileHandler.writeMapToFile1(map, fos);
                        } catch (FileNotFoundException ex) {
                            throw new RuntimeException(ex);
                        } catch (IOException ex) {
                            throw new RuntimeException(ex);
                        } catch (ClassNotFoundException ex) {
                            throw new RuntimeException(ex);
                        }
                        break;
                    }
                }
                for (Map.Entry<Integer, RegisterOrg> entry : map.entrySet())
                {
                    if (entry.getValue().getAppStatus().equals(Status.PENDING.name()))
                    {
                        tvDetails.setText("Org Name: "+entry.getValue().getOrganization().getOrgName() + "\nOrg Registration: " + entry.getValue().getOrgRegNum()
                                + "\nOrg PBO num: " + entry.getValue().getPboNum());
                        break;
                    }
                }
            }
        });
    }
}