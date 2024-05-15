package com.example.charitydonationapp.classes;

import java.io.Serializable;
import java.math.BigDecimal;

public class Organization implements Serializable
{
    private int orgCd;
    private String orgName;
    private BigDecimal donatedAmount;
    private BigDecimal estimateTax;

    public Organization(int orgCd, String orgName, BigDecimal donatedAmount, BigDecimal estimateTax)
    {
        this.orgCd = orgCd;
        this.orgName = orgName;
        this.donatedAmount = donatedAmount;
        this.estimateTax = estimateTax;
    }

    public BigDecimal getEstimateTax() {
        return estimateTax;
    }

    public void setEstimateTax(BigDecimal estimateTax) {
        this.estimateTax = estimateTax;
    }

    public void setOrgCd(int orgCd)
    {
        this.orgCd = orgCd;
    }

    public int getOrgCd()
    {
        return orgCd;
    }

    public String getOrgName()
    {
        return orgName;
    }

    public void setOrgName(String orgName)
    {
        this.orgName = orgName;
    }

    public BigDecimal getDonatedAmount() {
        return donatedAmount;
    }

    public void setDonatedAmount(BigDecimal donatedAmount) {
        this.donatedAmount = donatedAmount;
    }
}
