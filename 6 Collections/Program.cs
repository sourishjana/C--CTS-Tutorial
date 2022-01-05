
// ARRAYS:
/*using System;

namespace _07___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize array grades
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            string input = Console.ReadLine();
            // assign value to array grades at index 0
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 : {0}", grades[0]);


            // another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // thrid way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
            Console.ReadKey();
        }
    }
}*/


// Looping through arrays:
/*using System;
namespace _07___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Console.WriteLine(nums.Length);

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
            }

            Console.ReadKey();

            // Create an array with the names of five friends
            // greet all of them with a foreach loop

            string[] myFriends = { "Michael", "Wlad", "Ilja", "Andy", "Daniel" };

            foreach (string name in myFriends)
            {
                Console.WriteLine("Hi there {0}, my friend", name);
            }

            Console.ReadKey();
        }
    }
}
*/


// Multidimentional arrays:
/*using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initualize a 2-dimensional Array
            int[,] array2D = new int[3, 3];

            array2D[0, 0] = 11;
            array2D[0, 1] = 12;
            array2D[0, 2] = 13;
            array2D[1, 0] = 21;
            array2D[1, 1] = 22;
            array2D[1, 2] = 23;
            array2D[2, 0] = 31;
            array2D[2, 1] = 32;
            array2D[2, 2] = 33;

            //We access the Value 23
            //Note, that Indexes start with 0
            Console.WriteLine(array2D[1, 2]);


            foreach (var e in array2D) // in case of MD arrays we cant change the values in foreach loop
            {
                Console.Write(e+" ");
            }

            Console.WriteLine();

            for(int i = 0; i < array2D.GetLength(0); i++) // here we can change the values in 2D array
            {
                for(int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i,j] + " ");
                }
                Console.WriteLine();
            }


            //3-Dimensions are more complex, but the Conzept is the same
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001", "002" },
                    {"010", "011", "012" },
                    {"020", "021", "022" }
                },
                {
                    {"100", "101", "102" },
                    {"110", "111", "112" },
                    {"120", "121", "122" }
                },
                {
                    {"200", "201", "202" },
                    {"210", "211", "212" },
                    {"220", "221", "222" }
                },
                {
                    {"Hi", "I", "am" },
                    {"also", "part", "of" },
                    {"the", "3-dimensional", "array" }
                }

            };

            //We access the Value "201"
            Console.WriteLine(array3D[2, 0, 1]);

            //Hi
            Console.WriteLine(array3D[3, 0, 0]);

            //Will give us the Dimension of the corresponding Array
            int amountDimensions = array3D.Rank;
            Console.WriteLine("The Dimension is {0}", amountDimensions);

            //Multi-dimensional Arrays can also be created that way:
            string[,] arr2D = { { "00", "01" } };

            Console.WriteLine(arr2D[0, 0]);




            //To keep the Console open
            Console.Read();
        }
    }
}*/


// Jagged array:
/*using System;

namespace _07___JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //     index                   0    1    2    3  
            // normal array of type int : [15],[21],[23],[13]
            //     index                       0                        1                    2
            // jagged array of type int : [array1([15],[13],[5])],[array2([7],[8],[2])],[array3([2],[4],[1])]



            // declare jaggedArray
            int[][] jaggedArray = new int[3][]; // only specify rows

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            // alternative way:
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 }
            };

            Console.WriteLine("The Value in the middle of the first entry is {0}", jaggedArray2[0][2]);

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                    Console.WriteLine("{0} ", jaggedArray2[i][j]);
            }


            Console.ReadKey();
        }
    }
}*/


// using arrays as parameters
/*
using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            int[] happiness = { 2, 3, 4, 5, 6 };

            foreach (int grade in studentsGrades)
            {
                Console.WriteLine(" {0} ", grade);
            }

            Console.WriteLine("The average is: {0}", averageResult);
            Console.ReadKey();
        }

        static double GetAverage(int[] gradesArray) // arrays are pass by reference
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}*/


// Params keyword:
/*using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsMethod("sjdsk","sjds","kl","ajk","bbhd");
            Console.ReadKey();
        }
        public static void ParamsMethod(params string[] sentence)
        {
            for(int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }
    }
}*/


// min value using params:
/*using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinV2(3,7,1,2,9));
            Console.ReadKey();
        }
        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach(int number in numbers)
            {
                if (number < min) min = number;
            }
            return min;
        }
    }
}*/



/*
 
Non-generic: System.Collections
Can store any type of objcets 

Generic: System.Collections.Generic
Can store only one type

*/


// Arraylist: non-generic collection
/*
using System;
using System.Collections;

namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            // declaring an ArrayList with defined amount of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            // delete element with specific value from the arraylist
            myArrayList.Remove(13);
            myArrayList.Remove(13);
            myArrayList.Remove(13);
            // delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}*/


// Lists: This is a generic collection 
/*using System;
using System.Collections.Generic;

namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();

            lst.Add(12);
            lst.Add(12);
            lst.Add(14);
            lst.Add(15);
            lst.Add(16);

            foreach(int e in lst)
            {
                Console.WriteLine(e);
            }

            lst.Remove(16);
            lst.RemoveAt(2);

            for (int i = 0; i < lst.Count; i++) Console.WriteLine(lst[i]);

            lst.Clear();

            Console.ReadKey();
        }
    }
}*/


// Hashtable : non-generic
/*using System;
using System.Collections;

namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studTable = new Hashtable();
            Student s1 = new Student(1, "maria", 98);
            Student s2 = new Student(2, "Jason", 76);
            Student s3 = new Student(3, "clara", 43);
            Student s4 = new Student(4, "Steve", 55);


            studTable.Add(s1.Id, s1);
            studTable.Add(s2.Id, s2);
            studTable.Add(s3.Id, s3);
            studTable.Add(s4.Id, s4);

            if (studTable.ContainsKey(s1.Id))
            {
                Console.WriteLine("Key already exists");
            }
            //studTable.Add(s1.Id, s1);

            Student storedStud1 = (Student)studTable[s1.Id]; // as getting a value returns object so we need to typecast

            foreach(DictionaryEntry e in studTable)
            {
                Student s = (Student)e.Value;
                Console.WriteLine("Id: {0}, Name: {1}, GPA: {2}", s.Id, s.Name, s.Gpa);
            }

            foreach(Student s in studTable.Values)
            {
                // we can access only values
                Console.WriteLine("Id: {0}, Name: {1}, GPA: {2}", s.Id, s.Name, s.Gpa);
            }

            Console.ReadKey();
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gpa { get; set; }
        public Student(int id,string name,int gpa)
        {
            Id = id;Name = name;Gpa = gpa;
        }
    }
}*/


// Dictionary: generic
/*using System;
using System.Collections.Generic;

namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> sDict = new Dictionary<string, Student>();
            Student s1 = new Student(1, "maria", 98);
            Student s2 = new Student(2, "Jason", 76);
            Student s3 = new Student(3, "clara", 43);
            Student s4 = new Student(4, "Steve", 55);
            Student[] sarr = new Student[] { s1, s2, s3, s4 };

            foreach(Student s in sarr)
            {
                sDict.Add(s.Name, s);
            }

            Student storedStud1;
            if (sDict.ContainsKey(s1.Name))
                storedStud1 = sDict[s1.Name];

            Student stud = null;
            if (sDict.TryGetValue("clara",out stud))
            {
                Console.WriteLine("Id: {0}, Name: {1}, GPA: {2}", stud.Id, stud.Name, stud.Gpa);
            }

            // update entries:
            sDict[s2.Name] = new Student(5, "sourish", 99);

            // deleting elements
            sDict.Remove(s2.Name);

            foreach (KeyValuePair<string,Student> kvp in sDict)
            {
                Student s = kvp.Value;
                Console.WriteLine("Key:{0} ==> Id: {1}, Name: {2}, GPA: {3}", 
                    kvp.Key, s.Id, s.Name, s.Gpa);
            }

            Console.ReadKey();
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gpa { get; set; }
        public Student(int id, string name, int gpa)
        {
            Id = id; Name = name; Gpa = gpa;
        }
    }
}*/


// Stack : Generic
/*using System;
using System.Collections.Generic;

namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(12);
            stk.Push(13);
            stk.Push(14);
            stk.Push(15);

            int elem = stk.Pop();

            Console.WriteLine(stk.Peek());

            Console.WriteLine(stk.Count);

            Console.ReadKey();
        }
    }
}*/



// Queue: Generic
using System;
using System.Collections.Generic;

namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(11);
            q.Enqueue(13);

            int e = q.Dequeue();
            Console.WriteLine(e);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Count);
            Console.ReadKey();
        }
    }
}


