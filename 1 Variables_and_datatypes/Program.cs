/*

using System;

namespace Variables_and_datatypes
{
    class Program
    {
        static void Main(string[] args){

        }

        // coding standards:
        // XML documentation :

        /// <summary>
        /// This is a cool method
        /// </summary>
        static void coolMethod() // on hovering over the method 
        {
            // cool code
        }
    }
}

 */


/*
 
using System;

namespace Variables_and_datatypes
{
    class Program
    {
        static void Main(string[] args){
            
        }
    }
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);
    }    
}

 
 */


/*

using System;

namespace Variables_and_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / d2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(d1 + " devided by " + num2 + " is " + sumD);

            float f1 = 3.67f;
            float f2 = 2.3f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 : " + fDiv);



            string myname = "Denis";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();


            Console.WriteLine(lowerCaseMessage);

            Console.Read();

        }
    }
}
*/

/*
 
Value type vs reference type:

Value type: 
Holds the value directly on its own memory space
uses heap to store the value
e.g int,float,char,bool,decimal,double,etc

Reference type:
Instead of storing the value in the memory directly, stores the memory location of the actual data
e.g string,class,Array
when we copy a reference type there will be another memory location pointing the same actual data

 
 */

/*using System;

namespace Variables_and_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string and press enter ");
            string readInput = Console.ReadLine();
            Console.WriteLine(readInput);

            Console.Write("Enter a key and press enter ");
            int asciiValue = Console.Read();
            Console.WriteLine(asciiValue);
            Console.Read();
        }

    }
}*/

/*using System;

namespace Variables_and_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear(); // takes the background color over the whole console
            Console.WriteLine("My name is Sou");
            Console.Read();
        }

    }
}*/


/*using System;

namespace HelloWorld
{
    class Variables_and_datatypes
    {
        static void Main(string[] args)
        {
            // impicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;

            // typeConversion 
            string myString = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();
        }

    }
}
*/


/*using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;

            Console.WriteLine(resultInt);
            Console.Read();
        }

    }
}
*/

/*
using System;

namespace Variables_and_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            string name = "sou";

            // string concatenation:
            Console.WriteLine("My name is " + name + " and my age is " + age);

            // string formatting:
            Console.WriteLine("My name is {0} and my age is {1}",name,age);

            // string interpolation:
            Console.WriteLine($"My name is {name} and my age is {age}");

            // verbatim string:
            Console.WriteLine(@"My name is Sou \n and my age is "); // will not consider escape characters
            Console.WriteLine(@"F:\Documents\CTS DB1\CTS-Digital-Nurture-main\6 c#"); // helpful for storing this kind of strigs

            Console.Read();
        }

    }
}*/


/*
 
String is an object of system.String class
 
 */


/*using System;

namespace Variables_and_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Sourish";
            string lname = "Jana";
            string fullname = string.Concat(" ", fname, lname, " ");
            Console.WriteLine(fullname.Substring(2));
            Console.WriteLine(fullname.ToUpper());
            Console.WriteLine(fullname.ToLower());
            Console.WriteLine(fullname.Trim());
            Console.WriteLine(fname.IndexOf("s"));
            Console.WriteLine(String.IsNullOrWhiteSpace(fullname));

            string greet = String.Format("Hello my name is {0} {1}", fname, lname);
            Console.WriteLine(greet);

            Console.Read();
        }

    }
}*/


/*using System;

namespace Variables_and_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = Console.ReadLine()[0]; // take char as input
            Console.WriteLine(c);
            Console.Read();
        }

    }
}*/


using System;

namespace Variables_and_datatypes
{
    class Program
    {
        const double PI = 3.14159;
        const int months = 12, weeks = 52;
        const string bithday = "19.10.1999";
        static void Main(string[] args)
        {
            Console.Read();
        }

    }
}