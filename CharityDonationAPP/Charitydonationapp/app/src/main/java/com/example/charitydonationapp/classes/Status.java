package com.example.charitydonationapp.classes;

public enum Status
{
    APPROVED((short) 1),
    DECLINED((short) 2),
    PENDING((short) 3),
    MISSING_DOCUMENTS((short) 4),
   DONOR((short) 5),
    ORGANIZATION((short) 6),
    ADMIN((short) 7);

    private final short statusCd;
    Status(short statusCd) {this.statusCd = statusCd;}
    public  short getStatusCd(){return statusCd;}

}
