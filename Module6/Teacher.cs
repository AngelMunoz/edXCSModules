using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class Teacher:Person
    {

        public Teacher(string fname, string lname, DateTime birthdate, string addr1, string city, string state, long zip, string country, string addr2 = "")
            :base(fname, lname, birthdate, addr1, city, state, zip, country, addr2 = "")
        {
            Fname = fname;
            Lname = lname;
            Birthdate = birthdate;
            Addr1 = addr1;
            Addr2 = addr2;
            City = city;
            State = state;
            Zip = zip;
            Country = country;
        }
        public void GradeTest()
        {
            Console.WriteLine("The teacher Graded a test");
        }
        
    }
}
