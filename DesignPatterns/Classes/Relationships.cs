using System.Collections.Generic;
using DesignPatterns.Enums;

namespace DesignPatterns.Classes
{
    // low-level
    public class Relationships
    {
        public readonly List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();
        public List<(Person, Relationship, Person)> Relations => _relations;

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Parent, child));
            _relations.Add((child, Relationship.Child, parent));
        }
    }
}