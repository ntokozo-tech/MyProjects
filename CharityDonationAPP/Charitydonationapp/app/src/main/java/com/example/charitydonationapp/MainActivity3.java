package com.example.charitydonationapp;


import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.os.Environment;
import android.util.Log;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.example.charitydonationapp.classes.FileHandler;
import com.example.charitydonationapp.classes.Organization;
import com.example.charitydonationapp.classes.User;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Image;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.pdf.PdfWriter;

import java.io.ByteArrayOutputStream;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.List;
import java.util.Locale;
import java.util.Map;

public class MainActivity3 extends AppCompatActivity {
    private ImageView left_icon,right_icon;
    private EditText txtData;
    private Button btnDownload;
    private String details;
    private static int REQUEST_CODE = 1232;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main3);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        askPermission();
       left_icon  = findViewById(R.id.left_icon);
       right_icon = findViewById(R.id.right_icon);
       txtData = findViewById(R.id.txtData);
        btnDownload = findViewById(R.id.btnDownload);

        User user = (User) getIntent().getSerializableExtra("user");

        btnDownload.setOnClickListener(e->{
            try {
                createPdf();
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            } catch (DocumentException ex) {
                throw new RuntimeException(ex);
            }
        });
        left_icon.setOnClickListener(e->{
            Intent intent = new Intent(this, MainActivity2.class);
            intent.putExtra("user", user);
            startActivity(intent);
        });

        right_icon.setOnClickListener(e->{
            Intent intent = new Intent(this, MainActivity3.class);
            startActivity(intent);
        });
         details = "You donated to the following organizations:\n\n";
        try {
            FileInputStream fis = openFileInput("charity_donation4.bin");
            Map<Integer, List<Organization>> map = FileHandler.readMapFromFile(fis);
            if (map != null)
            {

                List<Organization> list = map.get(user.getUserCd());
                if(list != null)
                {
                    int count = 1;
                    for (Organization organization : list)
                    {
                        details += count + ". " + organization.getOrgName() + "the marginal rate is " + organization.getEstimateTax() +"\n\r";
                        count++;
                    }
                }
            }
            txtData.setText(details);
        } catch (IOException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
    }
    private void askPermission(){
        ActivityCompat.requestPermissions(this, new String[]{android.Manifest.permission.WRITE_EXTERNAL_STORAGE},REQUEST_CODE);
    }
    private void createPdf() throws IOException, DocumentException {
        Document document = new Document();

        String fileName = "tax_certificate" + new  SimpleDateFormat("yyyyMMdd_HHmmss",
                Locale.getDefault()).format(System.currentTimeMillis()) + ".pdf";
        String downloadDir = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DOWNLOADS) + "/" + fileName;
        PdfWriter.getInstance(document, new FileOutputStream(downloadDir));
        document.open();
        document.addAuthor("Charity Donation");
        document.add(new Paragraph(details));
        document.close();
        Toast.makeText(this, fileName + " downloaded", Toast.LENGTH_SHORT).show();
    }
}