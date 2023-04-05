using System;

public class kelompok
{
    public string member { get; set; }

    public kelompok() { }

    public kelompok(string member)
    {
        this.member = member;
    }
}

public class infoAnggota
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }