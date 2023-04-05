using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal7_1302213091_Kelompok_4
    public class DataMahasiswa1302213091
{
    public Fullname nama { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public int nim { get; set; }
    public DataMahasiswa1302213091()
    {

    }
    public class Fullname
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Fullname(string depan, string belakang)
        {
            this.firstName = depan;
            this.lastName = belakang;
        }
        public Fullname()
        {
        }
    }
    public DataMahasiswa1302213091(Fullname nama, string gender, int age, int nim)
    {
        this.nama = nama;
        this.gender = gender;
        this.age = age;
        this.nim = nim;
    }
}