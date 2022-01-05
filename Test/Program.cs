/*using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = "101202012345J12345";
            Console.WriteLine(code.Length);
            if (code.Length != 18)
            {
                Console.WriteLine("Invalid Book Code");
            }
            Console.WriteLine(code.Substring(0, 3));
            Console.WriteLine(code.Substring(3, 3));
            Console.WriteLine(code.Substring(7, 5));
            Console.WriteLine(code.Substring(12));
            *//*string deptCode = code.Substring(0, 2);
            int years = int.Parse(code.Substring(3, 6));
            int num = int.Parse(code.Substring(7, 11));
            string bookid = code.Substring(12);*//*
        }
    }
}*/


using System;
using System.Collections.Generic;
using System.Globalization;


namespace DateEx1              //DO NOT CHANGE the namespace name
{
    public class Program       //DO NOT CHANGE the class name
    {
        public static void Main(string[] args)    //DO NOT CHANGE the 'Main' method signature
        {
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            //Implement code here
            string dob = Console.ReadLine();
            Console.WriteLine(calculateAge(dob));
        }

        public static int calculateAge(string dateOfBirth)
        {
            //Implement code here
            //DateTime dob=Convert.ToDateTime(dateOfBirth);
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime dob = DateTime.ParseExact(dateOfBirth, "dd-mm-yyyy", provider);
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age = age - 1;

            return age;
        }


    }
}
