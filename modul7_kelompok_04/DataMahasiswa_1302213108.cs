using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_04
{
    public class DataMahasiswa_1302213108
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Fulladress adr { get; set; }
        public Fullcourses course { get; set; }

        public DataMahasiswa_1302213108()
        {

        }

        public class Fulladress
        {
            public string streetadress { get; set; }
            public string city { get; set; }
            public string state { get; set; }

            public Fulladress(string streetadress, string city, string state)
            {
                this.streetadress = streetadress;
                this.city = city;
                this.state = state;
            }

            public Fulladress()
            {

            }
        }

        public class Fullcourses
        {
            public string name { get; set; }
            public string code { get; set; }

            public Fullcourses(string name, string code)
            {
                this.name = name;
                this.code = code;
            }

            public Fullcourses()
            {

            }
        }
    }
}
