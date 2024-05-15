package com.example.charitydonationapp;

import static android.Manifest.permission.READ_EXTERNAL_STORAGE;
import static android.Manifest.permission.WRITE_EXTERNAL_STORAGE;

import android.content.Intent;
import android.os.Build;
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
import com.example.charitydonationapp.classes.Status;
import com.example.charitydonationapp.classes.User;

import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.Serializable;
import java.math.BigDecimal;
import java.util.StringTokenizer;

public class MainActivity extends AppCompatActivity {
    private EditText username;
    private EditText password;
    private Button btnLogin;
    private TextView txtInfo,txtLoginInfo,tvCreateAccount;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.M)
        {
            requestPermissions(new String[] {WRITE_EXTERNAL_STORAGE, READ_EXTERNAL_STORAGE}, 1);
        }
        tvCreateAccount = findViewById(R.id.tvCreateAccount);
        username = findViewById(R.id.username);
        password = findViewById(R.id.password);
        btnLogin = findViewById(R.id.btnLogin);
        txtInfo = findViewById(R.id.txtinfo);
        txtLoginInfo = findViewById(R.id.txtLoginInfo);
        username.setText("Mary");
        password.setText("password1");

        tvCreateAccount.setOnClickListener(e->{
            Intent intent = new Intent(MainActivity.this, MainActivity5.class);
            startActivity(intent);
        });
        btnLogin.setOnClickListener(e ->
        {
            FileInputStream fis = null;
            try {
                fis = openFileInput("user2.bin");
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
            User user = FileHandler.validaUser(username.getText().toString(), password.getText().toString(),fis);
            if (user != null)
            {
                if(user.getRole().equals(Status.ORGANIZATION.name()))
                {
                    Intent intent = new Intent(MainActivity.this, MainActivity4.class);
                    intent.putExtra("user", user);
                    startActivity(intent);
                }
                else if (user.getRole().equals(Status.DONOR.name())) {
                    Intent intent = new Intent(MainActivity.this, MainActivity2.class);
                    intent.putExtra("user", user);
                    startActivity(intent);
                }
                else if (user.getRole().equals(Status.ADMIN.name())) {
                    Intent intent = new Intent(MainActivity.this, MainActivity6.class);
                    intent.putExtra("user", user);
                    startActivity(intent);
                }

            }
            else
            {
                Toast.makeText(this, "Incorrect username or password", Toast.LENGTH_SHORT).show();;
            }
        });


    }
}