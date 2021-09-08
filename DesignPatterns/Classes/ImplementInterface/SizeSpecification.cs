using DesignPatterns.Enums;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes.ImplementInterface
{
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size _size;

        public SizeSpecification(Size size)
        {
            this._size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == _size;
        }
    }
}