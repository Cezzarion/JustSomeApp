using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSomeApp
{
    class Circle : Shape
    {
        internal override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Let's say this is circle");

            Console.WriteLine("Just added some code");
            Console.WriteLine("Now this should work");
            Console.WriteLine("Another line of code");
        }
    }
}
