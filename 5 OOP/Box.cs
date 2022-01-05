using System;
using System.Collections.Generic;
using System.Text;

namespace _5_OOP
{
    class Box
    {
        private int length;
        private int height;
        //private int width; // if using shorthnad props then no need to declare
        private int volume;

        public int Length { 
            get { return length; } 
            set {
                if (value < 0) throw new Exception("Length should be > 0");
                length = value; 
            } 
        }
        public int Height { get { return height; } set { height = value; } }
        //public int Width { get { return width; } set { width = value; } }
        public int Width { get; set; }

        public int Volume // read olny property
        {
            get { return length * Width * height; }
        }

        public Box(int length,int width,int height)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        // member - finalizer - destructor
        ~Box()
        {
            Console.WriteLine("Destruction of Box Object when goes out of scope");
        }

        public void displayInfo()
        {
            Console.WriteLine("length={0}, Height={1}, Width={2}, Volume={3}", 
                length, height, Width, volume = (length * height * Width)); 
        } // for shorthand we need to use capital Width
    }
}
