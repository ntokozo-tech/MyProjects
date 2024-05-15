package com.example.charitydonationapp.classes;

import java.io.ByteArrayInputStream;
import java.io.DataInputStream;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.math.BigDecimal;
import java.util.List;
import java.util.Map;
import java.util.StringTokenizer;

public class FileHandler
{
    private static User user;

    public static User getUser()
    {
        return user;
    }
    public static Map<Integer, List<Organization>> readMapFromFile(FileInputStream fis)
            throws IOException, ClassNotFoundException {
        int size = fis.available();
        byte[] buffer = new byte[size];
        DataInputStream dis = new DataInputStream(fis);
        dis.readFully(buffer);
        ByteArrayInputStream in = new ByteArrayInputStream(buffer);
        ObjectInputStream is = new ObjectInputStream(in);
        Object object = is.readObject();
        Map<Integer, List<Organization>> map = null;
        if (object instanceof Map)
        {
            map = (Map<Integer, List<Organization>>) object;
        }
        fis.close();
        return map;
    }
    public static Map<Integer, RegisterOrg> readRegOrgMapFromFile(FileInputStream fis)
            throws IOException, ClassNotFoundException {
        int size = fis.available();
        byte[] buffer = new byte[size];
        DataInputStream dis = new DataInputStream(fis);
        dis.readFully(buffer);
        ByteArrayInputStream in = new ByteArrayInputStream(buffer);
        ObjectInputStream is = new ObjectInputStream(in);
        Object object = is.readObject();
        Map<Integer, RegisterOrg> map = null;
        if (object instanceof Map)
        {
            map = (Map<Integer, RegisterOrg>) object;
        }
        fis.close();
        return map;
    }
    public static Map<Integer, User> readUserMapFromFile(FileInputStream fis)
            throws IOException, ClassNotFoundException {
        int size = fis.available();
        byte[] buffer = new byte[size];
        DataInputStream dis = new DataInputStream(fis);
        dis.readFully(buffer);
        ByteArrayInputStream in = new ByteArrayInputStream(buffer);
        ObjectInputStream is = new ObjectInputStream(in);
        Object object = is.readObject();
        Map<Integer, User> map = null;
        if (object instanceof Map)
        {
            map = (Map<Integer, User>) object;
        }
        fis.close();
        return map;
    }
    public static void writeMapToFile(Map<Integer, List<Organization>> donationMap, FileOutputStream fos) throws IOException, ClassNotFoundException
    {
        ObjectOutputStream oos = new ObjectOutputStream(fos);
        oos.writeObject(donationMap);
        fos.flush();
        fos.close();
        oos.flush();
        oos.close();
    }
    public static void writeMapToFile1(Map<Integer, RegisterOrg> registerOrgMap, FileOutputStream fos) throws IOException, ClassNotFoundException
    {
        ObjectOutputStream oos = new ObjectOutputStream(fos);
        oos.writeObject(registerOrgMap);
        fos.flush();
        fos.close();
        oos.flush();
        oos.close();
    }

    public static void writeUserMapToFile(Map<Integer, User> userMap, FileOutputStream fos) throws IOException, ClassNotFoundException
    {
        ObjectOutputStream oos = new ObjectOutputStream(fos);
        oos.writeObject(userMap);
        fos.flush();
        fos.close();
        oos.flush();
        oos.close();
    }

    public static User validaUser(String username, String password, FileInputStream fis)
    {
        User user = null;
        try
        {
            Map<Integer, User> map = readUserMapFromFile(fis);
            if(map != null)
            {
                for (Map.Entry<Integer, User> entry : map.entrySet())
                {
                    if (entry.getValue().getUsername().equals(username) && entry.getValue().getPassword().equals(password))
                    {
                        user = new User(entry.getValue().getUsername(),entry.getValue().getPassword(),entry.getValue().getMarginRate(),entry.getValue().getUserCd(),entry.getValue().getAmount(),entry.getValue().getRole(),entry.getValue().getUserType());
                    }
                }
            }
        } catch (IOException e1) {
            throw new RuntimeException(e1);
        } catch (ClassNotFoundException e) {
            throw new RuntimeException(e);
        }
        return user;
    }
    public static List<Organization> loadOrganisations(InputStream is) {
        List<Organization> organizations = null;
        try {
            int size = is.available();
            byte[] bytes = new byte[size];
            is.read(bytes);
            is.close();
            StringTokenizer tokenizer = new StringTokenizer(new String(bytes), "\n");
            while (tokenizer.hasMoreTokens()) {
                StringTokenizer tokenizer1 = new StringTokenizer(tokenizer.nextToken(), " ");
                int orgCd = Integer.parseInt(tokenizer1.nextToken());
                String orgName = "";
                while (tokenizer1.hasMoreTokens()) {
                    String data = tokenizer1.nextToken();
                    if (data.contains("\r")) {
                        StringTokenizer tokenizer2 = new StringTokenizer(data, "\r");
                        String value = tokenizer2.nextToken();
                        orgName += value;
                    } else {
                        orgName += data + " ";
                    }

                }
                Organization organization = new Organization(orgCd, orgName,BigDecimal.valueOf(Double.parseDouble(""))
                        ,BigDecimal.valueOf(0));
                organizations.add(organization);
            }
            return organizations;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return organizations;
    }
}
