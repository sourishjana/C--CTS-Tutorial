/*using System;

namespace _3_Decision_making__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr = Console.ReadLine();
            int num;
            if(int.TryParse(numStr,out num)) // try parse with if statement
            {
                Console.WriteLine("num is " + num);
            }
            else
            {
                num = 0;
                Console.WriteLine("Invalid input given so num is set to 0");
            }
        }
    }
}
*/


// NESTED IF STATEMENTS
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Some Booleans
            //Play around with the Values
            bool isRegistered = true;
            string userName = "";
            bool isAdmin = true;

            //User-Input
            //Try "Mike"
            Console.WriteLine("Please enter you username");
            userName = Console.ReadLine();

            //Code inside will be executed, if isRegistered is true
            if (isRegistered)
            {
                Console.WriteLine("User is registered");

                //Code inside will be executed, if userName is not ""
                if (userName != "")
                {
                    Console.WriteLine("Hello {0}", userName);

                    //Code inside will be executed, if userName is "Mike"
                    if (isAdmin)
                    {
                        Console.WriteLine("Oh, an Admin logged in. Welcome");
                    }
                }
            }

            //The same result can be achieved by using logical and
            if (isRegistered && userName != "" && isAdmin)
            {
                Console.WriteLine("User is registered");
                Console.WriteLine("Hello {0}", userName);
                Console.WriteLine("Oh, an Admin logged in. Welcome");

                if (userName == "Mike")
                {
                    Console.WriteLine("Welcome, Master Mike");
                }
            }

            //This will keep the Console open
            Console.Read();
        }
    }
}*/


// SWITCH CASE:
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 19;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "Frank";

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("username is Denis");
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;
            }



            Console.Read();
        }
    }
}*/


// TERNARY OPERATOR:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhanced_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //[condition] ? [first expression] : [second expression]
            //condition has to be either true or false

            //The conditional Operator is right-associative
            //That means, that a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e)

            //The conditional Operator cannot be overloaded.

            //in celcius
            //Play around with that Value
            int temperature = -5;

            //Our result
            string stateOfMatter;

            //Is the Temperature below 0 Degree Celsius?
            if (temperature < 0)
            {
                stateOfMatter = "solid";
            }
            //Is the Temperature higher than 100 Degree Celcius?
            else if (temperature > 100)
            {
                stateOfMatter = "gas";
            }
            //In all other Cases it must be liquid.
            else
            {
                stateOfMatter = "liquid";
            }

            Console.WriteLine("State of Matter is {0}", stateOfMatter);

            //The same result can be achieved by this
            //The enhanced Version of the If-Else-Statement from above
            stateOfMatter = temperature < 0 ? "solid" : (temperature > 100 ? "gas" : "liquid");

            Console.WriteLine("State of Matter is {0}", stateOfMatter);

            //To make sure the Console keeps open
            Console.Read();

        }
    }
}


