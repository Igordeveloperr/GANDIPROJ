using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Door : IAnimated
    {
        protected string Color;
        protected int Width;
        protected int Height;

        public Door(string color, int width, int height)
        {
            if (string.IsNullOrWhiteSpace(color)) throw new ArgumentException(nameof(color));
            if (width <= 0) throw new ArgumentException(nameof(width));
            if (height <= 0) throw new ArgumentException(nameof(height));

            Color = color;
            Width = width;
            Height = height;
        }

        private void Open()
        {
            Console.WriteLine("Door is open!");
        }
        private void Close()
        {
            Console.WriteLine("Door is close!");
        }

        public void Animate()
        {   
            this.Open();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}сек");
            }
            this.Close();
        }
    }
}
