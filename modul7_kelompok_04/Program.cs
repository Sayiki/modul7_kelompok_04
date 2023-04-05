// See https://aka.ms/new-console-template for more information

using modul7_kelompok_04;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302210096 data = new DataMahasiswa_1302210096();

        String jsonString = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Documents\\modul7_kelompok_04\\modul7_kelompok_04\\bin\\Debug\\net6.0\\jurnal7_1_1302210096.json");

        DataMahasiswa_1302210096 mhs = JsonSerializer.Deserialize<DataMahasiswa_1302210096>(jsonString);
        Console.WriteLine("Nama " + mhs.firstName + " " + mhs.lastName + " " + mhs.gender + " " + mhs.age + " " + mhs.address);

        for (int i = 0; i < mhs.courses.Count; i++)
        {
            Console.WriteLine("Course " + i);
            Console.WriteLine(mhs.courses[i].code);
            Console.WriteLine(mhs.courses[i].name);
            Console.WriteLine("");
        }
    }

}