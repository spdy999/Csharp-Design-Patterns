using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes.ImplementInterface
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            return items.Where(spec.IsSatisfied);
        }
    }
}