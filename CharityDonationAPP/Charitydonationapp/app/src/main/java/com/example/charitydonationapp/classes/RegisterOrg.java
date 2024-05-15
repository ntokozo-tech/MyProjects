package com.example.charitydonationapp.classes;

import com.example.charitydonationapp.classes.Organization;

import java.io.Serializable;

public class RegisterOrg implements Serializable
{
    private int RegCd;
    private String address;
    private String email;
    private String orgRegNum;
    private String webAddress;
    private String pboNum;
    private Organization organization;
    private String appStatus;

    public RegisterOrg(int regCd, String address, String email,
                       String orgRegNum, String webAddress, String pboNum, Organization organization,
                       String appStatus)
    {
        RegCd = regCd;
        this.address = address;
        this.email = email;
        this.orgRegNum = orgRegNum;
        this.webAddress = webAddress;
        this.pboNum = pboNum;
        this.organization = organization;
        this.appStatus = appStatus;
    }

    public String getAppStatus() {
        return appStatus;
    }

    public void setAppStatus(String appStatus) {
        this.appStatus = appStatus;
    }

    public int getRegCd() {
        return RegCd;
    }

    public void setRegCd(int regCd) {
        RegCd = regCd;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getOrgRegNum() {
        return orgRegNum;
    }

    public void setOrgRegNum(String orgRegNum) {
        this.orgRegNum = orgRegNum;
    }

    public String getWebAddress() {
        return webAddress;
    }

    public void setWebAddress(String webAddress) {
        this.webAddress = webAddress;
    }

    public String getPboNum() {
        return pboNum;
    }

    public void setPboNum(String pboNum) {
        this.pboNum = pboNum;
    }

    public Organization getOrganization() {
        return organization;
    }

    public void setOrganization(Organization organization) {
        this.organization = organization;
    }
}
