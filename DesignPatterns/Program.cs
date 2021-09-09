using System;
using DesignPatterns.Classes;

namespace DesignPatterns
{
    internal static class Program
    {
        private static int Area(Rectangle rc)
        {
            return rc.Width * rc.Height;
        }

        public static void Main(string[] args)
        {
            var rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Area(rc)}"); // Width: 2, Height: 3 has area 6

            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}"); // Width: 4, Height: 4 has area 16 <-- we declare override for Width and Height
        }
    }
}