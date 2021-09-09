using DesignPatterns.Classes;

namespace DesignPatterns
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            var research = new Research(relationships);
        }
    }
}