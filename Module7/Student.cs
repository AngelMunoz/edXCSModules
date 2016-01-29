using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    public class Student:Person
    {
        private static long _studentAmt;
        private Stack<int> _grades;

        public Student(string fname, string lname, DateTime birthdate, string addr1, string city, string state, long zip, string country, string addr2 = "", Stack<int> grades = null)
            :base(fname, lname, birthdate, addr1, city, state, zip, country, addr2)
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
            StudentAmt += 1;
            Grades = grades;
        }
        public void TakeTest()
        {
            Console.WriteLine("Student Took Test");
        }
        public static long StudentAmt
        {
            get
            {
                return _studentAmt;
            }

            set
            {
                _studentAmt = value;
            }
        }

        public Stack<int> Grades
        {
            get
            {
                return _grades;
            }

            set
            {
                _grades = value;
            }
        }
    }
}
