package com.example.charitydonationapp.classes;

import java.io.Serializable;
import java.math.BigDecimal;

public class User implements Serializable
{
    private String username;
    private String password;
    private int marginRate;
    private String role;
    private short userType;
    private int userCd;
    private BigDecimal amount;
    public  User(String username, String password, int marginRate, int userCd, BigDecimal amount, String role, short userType)
    {
        this.username = username;
        this.password = password;
        this.marginRate = marginRate;
        this.userCd = userCd;
        this.amount = amount;
        this.role = role;
        this.userType = userType;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }

    public short getUserType() {
        return userType;
    }

    public void setUserType(short userType) {
        this.userType = userType;
    }

    public String getUsername()
    {
        return username;
    }

    public int getUserCd()
    {
        return userCd;
    }

    public void setUserCd(int userCd)
    {
        this.userCd = userCd;
    }

    public int getMarginRate()
    {
        return marginRate;
    }

    public String getPassword()
    {
        return password;
    }

    public BigDecimal getAmount() {
        return amount;
    }

    public void setAmount(BigDecimal amount) {
        this.amount = amount;
    }

    public void setMarginRate(int marginRate)
    {
        this.marginRate = marginRate;
    }

    public void setPassword(String password)
    {
        this.password = password;
    }

    public void setUsername(String username)
    {
        this.username = username;
    }
}
