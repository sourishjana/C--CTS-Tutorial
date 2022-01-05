﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _8_polymorphism
{
    abstract class Shape
    {
        public string Name { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
        public abstract double Volume();
    }
}
