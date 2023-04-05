using System;

public class DataMahasiswa1302213080
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public alamatLengkap alamat { get; set; }
    public List<course> matkul { get; set; }

    public DataMahasiswa1302213080() { }

    public DataMahasiswa1302213080(string firstName, string lastName, string gender, int age, alamatLengkap alamat, List<course> matkul)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.age = age;
        this.alamat = alamat;
        this.matkul = matkul;
    }
}

public class alamatLengkap
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }

    public alamatLengkap() { }

    public alamatLengkap(string streetAddress, string city, string state)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
    }
}

public class course
{
    public string code { get; set; }
    public string name { get; set; }

    public course() { }

    public course(string code, string name)
    {
        this.code = code;
        this.name = name;
    }
}