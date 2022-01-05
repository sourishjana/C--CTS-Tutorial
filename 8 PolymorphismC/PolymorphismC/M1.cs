using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class M1 : Audi
    {
        public M1(int hp, string color, string model) : base(hp, color, model)
        {

        }
        public override void Repair()
        {
            Console.WriteLine("repairing M1");
        }
    }
}
