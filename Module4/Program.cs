using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class App
    {
        static void Main(string[] args)
        {

            Student[] students = new Student[5];

            students[0] = new Student("angel", "munoz", "dir1", "juarez", "chihuahua", 12345, "mexico");
            students[1] = new Student("daniel", "gonzalez", "dir1", "juarez", "chihuahua", 12589, "mexico", "dir2");
            students[2] = new Student("javier", "martinez", "dir1", "juarez", "chihuahua", 54321, "mexico");
            students[3] = new Student("silvia", "avila", "dir1", "juarez", "chihuahua", 01597, "mexico", "dir2");
            students[4] = new Student("karina", "lopez", "dir1", "juarez", "chihuahua", 75312, "mexico");

            foreach (Student student in students)
            {
                Console.WriteLine("First Name: {0} Last Name: {1} Addres Line 1: {2} Address Line 2: {3} City: {4} State: {5} Zip: {6} Country: {7}",
                                  student.fname, student.lname, student.addr1, student.addr2, student.city, student.state, student.zip, student.country);
                Console.WriteLine();
            }

            Console.ReadKey();

        }
        public struct Student
        {
            public string fname;
            public string lname;
            public string addr1;
            public string addr2;
            public string city;
            public string state;
            public long zip;
            public string country;

            public Student(string fname, string lname, string addr1, string city, string state, long zip, string country, string addr2 = "")
            {
                this.fname = fname;
                this.lname = lname;
                this.addr1 = addr1;
                this.addr2 = addr2;
                this.city = city;
                this.state = state;
                this.zip = zip;
                this.country = country;
            }
        }
        public struct Teacher
        {
            public string fname;
            public string lname;
            public string addr1;
            public string addr2;
            public string city;
            public string state;
            public long zip;
            public string country;

            public Teacher(string fname, string lname, string addr1, string city, string state, long zip, string country, string addr2 = "")
            {
                this.fname = fname;
                this.lname = lname;
                this.addr1 = addr1;
                this.addr2 = addr2;
                this.city = city;
                this.state = state;
                this.zip = zip;
                this.country = country;
            }

        }
        public struct Program
        {
            string pName;
            string dHead;
            string degrees;
            public Program(string pName, string dHead, string degrees = "")
            {
                this.pName = pName;
                this.dHead = dHead;
                this.degrees = degrees;
            }

        }
        public struct Course
        {
            //Course Name	Credits	Duration in Weeks	Teacher
            string cName;
            int credits;
            int weeks;
            Teacher teacher;

            public Course(string cName, int credits, int weeks, Teacher teacher)
            {
                this.cName = cName;
                this.credits = credits;
                this.weeks = weeks;
                this.teacher = teacher;
            }
        }
    }
}
