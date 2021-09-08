using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products,
            Size size)
        {
            return products.Where(product => product.Size == size);
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products,
            Color color)
        {
            return products.Where(product => product.Color == color);
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products,
            Size size, Color color)
        {
            return products.Where(product => product.Color == color && product.Size == size);
        }
    }
}