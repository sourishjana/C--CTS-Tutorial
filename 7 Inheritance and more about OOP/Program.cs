
// IEnumerable and IEnumerator

/*

Many collections use this interface so that we can use foreach loop through them
If any collection implements IEnumerable interface then it becomes countable 

2 versions:
1) IEnumerable<> for generic collections
2) IEnumerable for non generic collections

IEnumerable<T> contains a single method that must be implemented while implementing the interface
GetEnumerator() returns a IEnumerator object 
IEnumerator<T> provides the ability to iterate through the collection
by exposing a current property tha points at the object we are currently at in the collection
 

When to use IEnumerable:
=> Collection has a massive data table and you dont want to copy the entire thing into the memory

When not to use IEnumerable:
=> You need results right away and possible mutating the objects later on 

 */

/*using System;
using System.Collections;
using System.Collections.Generic;

namespace _7_Inheritance_and_more_about_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            foreach(Dog d in shelter)
            {
                Console.WriteLine("DogName: {0}, IsNaughty: {1}", d.Name, d.IsNaughty);
            }
        }
    }

    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughty { get; set; }
        public Dog(string name,bool isnaughty)
        {
            Name = name; IsNaughty = isnaughty;
        }
    }

    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;
        public DogShelter()
        {
            dogs = new List<Dog>
            {
                new Dog("Casper",false),
                new Dog("Sif",true),
                new Dog("Oreo",false),
                new Dog("Pixel",false),
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            //throw new NotImplementedException();
            return dogs.GetEnumerator(); // we need to implement what should be returned
            // Here we want only the Dogs list to get enumerated.
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}*/



// IEnumerable : Application 1

/*using System;
using System.Collections.Generic;

namespace _7_Inheritance_and_more_about_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> col = GetCollection(1);
            foreach (int e in col) Console.WriteLine(e);

            col = GetCollection(2);
            foreach (int e in col) Console.WriteLine(e);

            col = GetCollection(3);
            foreach (int e in col) Console.WriteLine(e);
        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> l = new List<int> { 1, 3, 4, 6, 7, 8 };
            
            Queue<int> q = new Queue<int>();
            q.Enqueue(3);
            q.Enqueue(1);
            q.Enqueue(4);
            q.Enqueue(5);

            int[] arr = new int[] { 8, 9, 10, 3 };

            // we can return any kind of collection
            if (option == 1) return l;
            else if (option == 2) return q;
            else return arr;
        }

    }
}*/


// IEnumerable : Application 2

using System;
using System.Collections.Generic;

namespace _7_Inheritance_and_more_about_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int> { 1, 3, 4, 6, 7, 8 };
            Console.WriteLine("Sum = " + GetCollectionSum(l));

            Queue<int> q = new Queue<int>();
            q.Enqueue(3);
            q.Enqueue(1);
            q.Enqueue(4);
            q.Enqueue(5);
            Console.WriteLine("Sum = " + GetCollectionSum(q));

            int[] arr = new int[] { 8, 9, 10, 3 };
            Console.WriteLine("Sum = " + GetCollectionSum(arr));

        }

        static int GetCollectionSum(IEnumerable<int> col)
        {
            int sum = 0;
            foreach (int e in col) sum += e;
            return sum;
        }

    }
}
