using System;
using System.Collections.Generic;
using System.Text;

namespace _8_polymorphism
{
    class Sphere:Shape
    {
        public double Radius { get; set; }
        public Sphere(int r)
        {
            Radius = r;
            Name = "Sphere";
        }
        public override double Volume()
        {
            //throw new NotImplementedException();
            return (4/3)*Math.PI*Math.Pow(Radius, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Sphere has a Radius of {Radius}");
        }
    }
}
