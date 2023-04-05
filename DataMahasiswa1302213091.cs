using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal7_1302213091_Kelompok_4
{
    public class DataMahasiswa1302213091
    {
        public Fullname nama { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string courses { get; set; }
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
        public DataMahasiswa1302213091(Fullname name, string gender, int age, string address, string streetAddress, string city, string state)
        {
            this.nama = name;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }
}