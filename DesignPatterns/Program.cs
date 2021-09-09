using System;
using System.Diagnostics;
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

            var p = new Persistence();
            const string filename = @"./journal.txt";
            p.SaveToFile(j, filename, true); // save journal to .txt file
            Process.Start(filename); // run the the journal.txt file
        }
    }
}