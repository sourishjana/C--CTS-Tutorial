using System;

namespace _5_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normal class
            /*Human h = new Human("Sourish", "Jana");
            h.firstName = "kumar";
            h.introduce();*/


            // Constructors and its type
            /*Human denis = new Human("Denis", "Panjuta", "green", 29);
            denis.IntroduceMyself();

            Human amalia = new Human("Amalia", "Panjuta", "blue");
            amalia.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMyself();

            Human frank = new Human("Frank", "Walter", 25);
            frank.IntroduceMyself();*/


            // Properties:
            Box b = new Box(9,5,6);
            b.Length = 9;
            b.Height = 5;
            b.Width = 6;
            b.displayInfo();

        }
    }
}
