using System.Collections.Generic;
using DesignPatterns.Enums;

namespace DesignPatterns.Classes
{
    // low-level
    public class Relationships
    {
        public readonly List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Child, child));
            _relations.Add((parent, Relationship.Child, child));
        }
    }
}