// FOR LOOPS:
/*using System;

namespace _4_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter < 20; counter += 2)
            {
                Console.WriteLine(counter);
            }
            Console.Read();
        }
    }
}*/


// DO WHILE LOOP:
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int lenghtOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLenght = nameOfAFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfAFriend;
            } while (lenghtOfText < 20);
            Console.WriteLine("Thanks, that was enough! " + wholeText);
            Console.Read();
        }
    }
}
*/


// WHILE LOOPS:
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else" +
                    " + enter if you want to finish counting");
                enteredText = Console.ReadLine();

                counter++;
                Console.WriteLine("Current people count is {0}", counter);

            }
            Console.WriteLine("{0} people are inside the bus. Press enter to close the program", counter);
            Console.Read();
        }
    }
}
*/

// Break and continue:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int counter = 0; counter < 10; counter++)
            {

                if (counter % 2 == 0)
                {
                    Console.WriteLine("Now comes an odd number!");
                    continue;
                }
                Console.WriteLine(counter);
            }
            Console.Read();

        }
    }
}
