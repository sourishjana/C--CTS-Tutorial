using System;

namespace _8_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Cube(4), new Sphere(3) };
            foreach(Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("volume is = " + s.Volume());

                Cube c = s as Cube; // another way of type casting
                if(c is null)
                {
                    Console.WriteLine("It is a not a cube");
                }
                if(c is Cube) // checking a type
                {
                    Console.WriteLine("It is a cube");
                }

            }
        }
    }
}



/*

What an object is      -> Abstrct class
What an object must do -> Interface
 
 */