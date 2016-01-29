using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(); // new empty arraylist
            //student 1
            Student s1 = new Student("Angel", "Munoz", new DateTime(1992, 05, 16), "Dir1", "Juarez", "Chihuahua", 12345, "Mexico");
            s1.Grades = new Stack<int>(5);
            s1.Grades.Push(10);
            s1.Grades.Push(9);
            s1.Grades.Push(8);
            s1.Grades.Push(9);
            s1.Grades.Push(8);
            // student 2
            Student s2 = new Student("Perla", "Lopez", new DateTime(1992, 12, 10), "Dir1", "Juarez", "Chihuahua", 12345, "Mexico", "Dir2");
            s2.Grades = new Stack<int>(5);
            s2.Grades.Push(8);
            s2.Grades.Push(9);
            s2.Grades.Push(8);
            s2.Grades.Push(9);
            s2.Grades.Push(10);
            // student 3
            Student s3 = new Student("Victor", "Munoz", new DateTime(1992, 07, 10), "Dir1", "Juarez", "Chihuahua", 12345, "Mexico");
            s3.Grades = new Stack<int>(5);
            s3.Grades.Push(9);
            s3.Grades.Push(9);
            s3.Grades.Push(8);
            s3.Grades.Push(9);
            s3.Grades.Push(8);
            // add students to the arraylist
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            
            //teachers
            Teacher t1 = new Teacher("Dora", "Rivero", new DateTime(1980, 05, 16), "Dir1", "Juarez", "Chihuahua", 12345, "Mexico");
            Teacher t2 = new Teacher("Ricardo", "Trejo", new DateTime(1981, 03, 19), "Dir1", "Juarez", "Chihuahua", 12345, "Mexico", "Dir2");
            Teacher t3 = new Teacher("Victor", "Arellanes", new DateTime(1980, 05, 10), "Dir1", "Juarez", "Chihuahua", 12345, "Mexico");
            Teacher[] teachers = { t1, t2, t3 };

            Course PCS = new Course("Programming with C#", 15, 6, teachers, students);
            Course PFS = new Course("Programming with F#", 12, 7, teachers, students);
            Course PJ = new Course("Programming with Java", 15, 5, teachers, students);
            Course[] courses = { PCS, PFS, PJ };
            Degree bachelor = new Degree("Bachelor", 500, courses);
            UProgram uprogram = new UProgram("Information Technology", "Mike Perez", bachelor);
            Console.WriteLine("Program: {0}\nDegree: {1}", uprogram.PName, uprogram.Degree.Name);
            Console.WriteLine("Course:{0}\nStudents in Course: {1}", uprogram.Degree.Courses[0].CName, Student.StudentAmt);
            foreach(Student student in PCS.Students)
            {
                student.TakeTest();
            }
            foreach (Teacher teacher in PCS.Teachers)
            {
                teacher.GradeTest();
            }
            // calling method on Course object to list the students in course
            PCS.ListStudents();
            Console.ReadKey();
            
        }
    }
}
