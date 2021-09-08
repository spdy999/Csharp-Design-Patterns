using System;
using DesignPatterns.Classes;

namespace DesignPatterns
{
    internal static class Program
    {
        public static int Area(Rectangle rc) => rc.Width * rc.Height;
        public static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Area(rc)}"); // Width: 2, Height: 3 has area 6

        }
    }
}