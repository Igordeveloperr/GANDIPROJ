using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Wheel : IAnimated
    {
        public void Animate()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Я кручусь и мне похуй!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
