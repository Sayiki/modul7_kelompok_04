using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_04
{
    public class DataMahasiswa_1302210096
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public adr address { get; set; }
        public List<kurse> courses { get; set; }

        public DataMahasiswa_1302210096()
        {

        }

        public class adr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }

            public adr(string streetAddress, string city, string state)
            {
                this.streetAddress = streetAddress;
                this.city = city;
                this.state = state;
            }

            public adr()
            {

            }
        }

        public class kurse
        {
            public string code { get; set; }
            public string name { get; set; }

            public kurse(string kode, string nama){
                this.code = kode;
                this.name = nama;
            }
            public kurse()
            {

            }

        }


        public DataMahasiswa_1302210096(string firstName, string lastName , string gender, int age, adr address, List<kurse> courses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.courses = courses;
        }



    }
}
