using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // инстанс класса Дверь
            Door door = new Door("red", 100, 200);
            door.Animate();

            Wheel wheel = new Wheel();
            wheel.Animate();
        }
    }
}
