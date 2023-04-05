using System.Text.Json;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302213080 dataMahasiswa = new DataMahasiswa1302213080();
        String jsonString = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Documents\\modul7_kelompok_04\\modul7_kelompok_04\\jurnal7_1_1302213080.json");

        DataMahasiswa1302213080 dataMahasiswa1302213080 = JsonSerializer.Deserialize<DataMahasiswa1302213080>(jsonString);
        Console.WriteLine("Nama : " + dataMahasiswa.firstName + " " + dataMahasiswa.lastName + "jenis kelamin : " + dataMahasiswa.gender + "umur : " + dataMahasiswa.age + "Alamat : " + 
            dataMahasiswa.alamat.streetAddress + " " + dataMahasiswa.alamat.city + dataMahasiswa.alamat.state + "Mata Kuliah : " + dataMahasiswa.matkul);
    }
}