﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door("red", 100, 200);
            door.Animate();
            Console.WriteLine("ЭТО САМЫЙ СМЕШНОЙ РЕДАКТОР КОДА!!!!!!!!!!!!");
            Wheel wheel = new Wheel();
            wheel.Animate();
        }
    }
}