using System;
using System.Collections.Generic;
using System.Text;

namespace _8_polymorphism
{
    class Cube:Shape
    {
        public double Length { get; set; }
        public Cube(int l)
        {
            Length = l;
            Name = "Cube";
        }
        public override double Volume()
        {
            //throw new NotImplementedException();
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The cube has a Length of {Length}");
        }
    }
}
