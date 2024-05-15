package com.example.charitydonationapp;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
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
import com.example.charitydonationapp.classes.Status;
import com.example.charitydonationapp.classes.User;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.HashMap;
import java.util.Map;
import java.util.Random;

public class MainActivity5 extends AppCompatActivity
{
    private String[] items = {Status.DONOR.name(), Status.ORGANIZATION.name(),Status.ADMIN.name()};
    private AutoCompleteTextView autoCompleteTxt;
    private ArrayAdapter<String> adapterItems;
    private EditText create_gross_income, create_username, create_password, create_confirm_passord;
    private Button btnCreate;
    private TextView tvLogin;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main5);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        tvLogin = findViewById(R.id.tvLogin);
        create_gross_income = findViewById(R.id.create_gross_income);
        create_username = findViewById(R.id.create_username);
        create_password = findViewById(R.id.create_password);
        create_confirm_passord = findViewById(R.id.create_confirm_passord);
        autoCompleteTxt = findViewById(R.id.auto_complete_txt);
        btnCreate = findViewById(R.id.btnCreate);
        adapterItems = new ArrayAdapter<>(this,R.layout.list_item, items);
        autoCompleteTxt.setAdapter(adapterItems);
        final char[][] chars = {new char[100]};
        autoCompleteTxt.setOnItemClickListener(new AdapterView.OnItemClickListener() {

            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                String item = adapterView.getItemAtPosition(i).toString();
                chars[0] = item.toCharArray();
            }
        });
        tvLogin.setOnClickListener(e->{
            Intent intent = new Intent(this, MainActivity.class);
            startActivity(intent);
        });
        btnCreate.setOnClickListener(e->{
            //TODO read the file user.bin
            if (create_confirm_passord.getText().toString().isEmpty() || create_password.getText().toString().isEmpty()
            || create_username.getText().toString().isEmpty() || create_gross_income.getText().toString().isEmpty())
            {
                Toast.makeText(this, "Please fill in all fields", Toast.LENGTH_SHORT).show();
                return;
            }
             Map<Integer, User> userMap = new HashMap<>();
            FileInputStream fis = null;
            try {
                fis = openFileInput("user2.bin");
                userMap = FileHandler.readUserMapFromFile(fis);
            } catch (FileNotFoundException ex) {
                ex.printStackTrace();
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            } catch (ClassNotFoundException ex) {
                ex.printStackTrace();
            }

            String selectedItems = "";
            for(int i = 0; i < chars[0].length; i++)
            {
                selectedItems += String.valueOf(chars[0][i]);
            }
            short usertype = 0;
            int userCd = 1;
            for(Map.Entry<Integer, User> entry : userMap.entrySet())
            {
                userCd = entry.getKey();
            }
            userCd += 1;
            String role = "";
            if (selectedItems.equals(Status.DONOR.name()))
            {
                usertype = Status.DONOR.getStatusCd();
                role = Status.DONOR.name();
            } else if (selectedItems.equals(Status.ORGANIZATION.name())) {
                usertype = Status.ORGANIZATION.getStatusCd();
                role = Status.ORGANIZATION.name();
            }else if (selectedItems.equals(Status.ADMIN.name())) {
                usertype = Status.ADMIN.getStatusCd();
                role = Status.ADMIN.name();
            }
            String username = create_username.getText().toString();
            String password = create_password.getText().toString();
            Random rand = new Random();
            int marginRate= rand.nextInt(10);
            BigDecimal amount = BigDecimal.valueOf(Double.parseDouble(create_gross_income.getText().toString()));

            if(create_confirm_passord.getText().toString().equals(create_password.getText().toString()))
            {
                User user = new User(username,password,marginRate,userCd, amount,role,usertype);
                userMap.put(userCd, user);
                try {
                    FileOutputStream fos = openFileOutput("user2.bin", MODE_PRIVATE);
                    FileHandler.writeUserMapToFile(userMap, fos);
                    Toast.makeText(this, "Account created successfully", Toast.LENGTH_SHORT).show();
                    Intent intent = new Intent(this, MainActivity.class);
                    startActivity(intent);
                } catch (FileNotFoundException ex) {
                    ex.printStackTrace();
                } catch (IOException ex) {
                    throw new RuntimeException(ex);
                } catch (ClassNotFoundException ex) {
                    ex.printStackTrace();
                }
            }else{
                Toast.makeText(this, "Password do not match", Toast.LENGTH_SHORT).show();
            }


        });

    }
}