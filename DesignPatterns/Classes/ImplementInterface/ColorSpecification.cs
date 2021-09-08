using DesignPatterns.Enums;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes.ImplementInterface
{
    public class ColorSpecification : ISpecification<Product>
    {
        private readonly Color _color;

        public ColorSpecification(Color color)
        {
            this._color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == _color;
        }
    }
}