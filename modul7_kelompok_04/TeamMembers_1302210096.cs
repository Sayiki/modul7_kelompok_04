using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_04
{
    public class TeamMembers_1302210096
    {
        public List<member> members { get; set; }

        public TeamMembers_1302210096()
        {

        }
    

        public class member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }

            public member(string firstName, string lastName, string gender, int age, string nim)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.gender = gender;
                this.age = age;
                this.nim = nim;

                
            }
            public member() { }



        }

        public TeamMembers_1302210096(member members)
        {
            this.members = members;
        }
    }
}
