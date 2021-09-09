using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class Research
    {
        public Research(IRelationshipBrowser browser)
        {
            foreach (var person in browser.FindAllChildrenOf("John"))
                Console.WriteLine($"John has a child called {person.Name}");
        }
    }
}