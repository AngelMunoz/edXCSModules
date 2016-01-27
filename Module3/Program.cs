using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {

        static void Main(string[] args)
        {
            GetStudentData();
            GetProfData();
            Console.ReadKey();
        }
        static void GetProfData()
        {
            Console.WriteLine("Enter teacher's first name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter teacher's last name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter teacher's birthdate:");
            string birthday = Console.ReadLine();
            PrintProfDetails(fName, lName, birthday);
        }

        static void GetStudentData()
        {
            Console.WriteLine("Enter student's first name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter student's last name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter student's birthdate:");
            string birthday = Console.ReadLine();
            PrintStudentDetails(fName, lName, birthday);

        }
        static void PrintProfDetails(string fName, string lName, string birthdate)
        {
            try
            {
                ValidateBirthdate(birthdate);
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("teacher's Details: ");
                Console.WriteLine("First Name {0}\nLast Name: {1}\nBirthday: {2}", fName, lName, birthdate);

            }
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            try
            {
                ValidateBirthdate(birthday);
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Student's Details: ");
                Console.WriteLine("First Name {0}\nLast Name: {1}\nBirthday: {2}", first, last, birthday);

            }
        }

        static void ValidateBirthdate(string birthdate)
        {
            throw new NotImplementedException("Birthdate validation not implemented yet");
        }
    }
}