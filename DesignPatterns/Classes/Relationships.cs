using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Enums;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    // low-level
    public class Relationships : IRelationshipBrowser
    {
        public readonly List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();
        public List<(Person, Relationship, Person)> Relations => _relations;

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return _relations.Where(
                x => x.Item1.Name == name &&
                     x.Item2 == Relationship.Parent
            ).Select(r => r.Item3);
        }

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Parent, child));
            _relations.Add((child, Relationship.Child, parent));
        }
    }
}