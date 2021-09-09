using System;
using System.Linq;
using DesignPatterns.Enums;

namespace DesignPatterns.Classes
{
    public class Research
    {
        public Research(Relationships relationships)
        {
            var relations = relationships.Relations;
            foreach (var r in relations.Where(
                x => x.Item1.Name == "John" &&
                     x.Item2 == Relationship.Parent
            ))
                Console.WriteLine($"John has a child called {r.Item3.Name}");
        }
    }
}