using System;
using DesignPatterns.Classes;

namespace DesignPatterns
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);
        }
    }
}