
// Reading from a text File:
/*using System;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading Tect from a File
            //exchange the adress of the file with the one you want to use
            string text = System.IO.File.ReadAllText(@"F:\Documents\CTS pre joining studies\1 C# programming\textFile.txt");

            Console.WriteLine("\nTextfile contains the following text:\n{0}", text);

            //Receive the Text line by line.
            string[] lines = System.IO.File.ReadAllLines(@"F:\Documents\CTS pre joining studies\1 C# programming\textFile.txt");

            Console.WriteLine("\nContent of the file line by line: \n");
            foreach(string line in lines)
            {
                //\t is a tab
                Console.WriteLine( "\t" + line);
            }

            //To keep the Console open.
            Console.Read();
        }
    }
}
*/


using System;
using System.IO;

namespace FileIOc
{
    class Program
    {


        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "First 250", "Second 242", "Third 240" };

            File.WriteAllLines(@"F:\Documents\CTS pre joining studies\1 C# programming\textFileWrite.txt", lines);
            
            /*
            // Method 2
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"F:\C# Masterclass Course\Projects\Assets\" + fileName + ".txt", input);
            */


            // Method 3
            using (StreamWriter file = new StreamWriter(@"F:\Documents\CTS pre joining studies\1 C# programming\textFile.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"F:\Documents\CTS pre joining studies\1 C# programming\textFile.txt", true))
            {
                file.WriteLine("Additional line");
            }

            Console.ReadKey();
        }
    }
}
