// See https://aka.ms/new-console-template for more information
using modul7_kelompok_04;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302213108 data = new DataMahasiswa_1302213108();
        String jsonString = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Downloads\\modul7_kelompok4\\modul7_kelompok_04\\bin\\Debug\\net6.0\\jurnal7_1_1302213108.json");
        data = JsonSerializer.Deserialize<DataMahasiswa_1302213108>(jsonString);
        Console.WriteLine("Nama "+ data.firstname+ data.lastname + "Berjenis Kelamin "+ data.gender + "Berumur" + data.age+ "dan BerAlamat di" + data.adr+ "dan Mengambil mata kuliah"+ data.course);

    }
}
