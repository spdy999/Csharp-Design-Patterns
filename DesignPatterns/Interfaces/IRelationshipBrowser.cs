using System.Collections.Generic;
using DesignPatterns.Classes;

namespace DesignPatterns.Interfaces
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}