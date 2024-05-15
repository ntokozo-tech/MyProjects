package com.example.charitydonationapp;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
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
import java.util.HashMap;
import java.util.Map;

public class MainActivity4 extends AppCompatActivity {
    private EditText orgName, orgRegNum, pboNum, email, pFullPName, pTitle, pPosition, address, webUrl;
    private TextView tvAlreadyReg;
    private Button btnSumit;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main4);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        btnSumit = findViewById(R.id.btnSumit1);
        webUrl = findViewById(R.id.webUrl);
        address = findViewById(R.id.address);
        tvAlreadyReg = findViewById(R.id.tvAlreadyReg);
        orgName = findViewById(R.id.orgName);
        orgRegNum = findViewById(R.id.orgRegNum);
        pboNum = findViewById(R.id.pboNum);
        email = findViewById(R.id.email);
        pFullPName = findViewById(R.id.pFullPName);
        pTitle = findViewById(R.id.pTitle);
        pPosition = findViewById(R.id.pPosition);
        User user = (User) getIntent().getSerializableExtra("user");

        tvAlreadyReg.setOnClickListener(e -> {
            Intent intent = new Intent(this, MainActivity.class);
            startActivity(intent);
        });
        btnSumit.setOnClickListener(e -> {
            if (!orgName.getText().toString().isEmpty() || !orgRegNum.getText().toString().isEmpty()
                    || !pboNum.getText().toString().isEmpty() || !email.getText().toString().isEmpty()
                    || !pFullPName.getText().toString().isEmpty() || !pTitle.getText().toString().isEmpty()
                    || !pPosition.getText().toString().isEmpty()
                    || !address.getText().toString().isEmpty()) {
                Map<Integer, RegisterOrg> registerOrgMap = new HashMap<>();
                FileInputStream fis = null;
                try {
                    //create and write a new map
                    //read map
                    fis = openFileInput("organization_registration.bin");
                    registerOrgMap = FileHandler.readRegOrgMapFromFile(fis);
                    int regCd = 1;
                    for (Map.Entry<Integer, RegisterOrg> entry : registerOrgMap.entrySet()) {
                        regCd = entry.getKey();
                    }
                    regCd += 1;
                    int orgCd = 1;
                    for (Map.Entry<Integer, RegisterOrg> entry : registerOrgMap.entrySet()) {
                        if (entry.getValue().getOrganization() != null) {
                            orgCd = entry.getValue().getOrganization().getOrgCd();
                        }
                    }
                    orgCd += 1;
                    Organization organization = new Organization(orgCd, orgName.getText().toString(), null, null);
                    RegisterOrg registerOrg = new RegisterOrg(regCd, address.getText().toString(), email.getText().toString()
                            , orgRegNum.getText().toString(), webUrl.getText().toString(), pboNum.getText().toString(), organization,
                            Status.PENDING.name());
                    registerOrgMap.put(regCd, registerOrg);
                    FileOutputStream fos = openFileOutput("organization_registration.bin", MODE_PRIVATE);
                    FileHandler.writeMapToFile1(registerOrgMap, fos);
                    Toast.makeText(this, "Application submitted successfully", Toast.LENGTH_SHORT).show();

                } catch (FileNotFoundException ex) {
                    ex.printStackTrace();
                } catch (IOException ex) {
                    throw new RuntimeException(ex);
                } catch (ClassNotFoundException ex) {
                    throw new RuntimeException(ex);
                }

            } else {
                Toast.makeText(this, "Please fill in the missing field", Toast.LENGTH_SHORT).show();
            }
        });

    }
}