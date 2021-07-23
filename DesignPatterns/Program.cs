using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Huge
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

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
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = {apple, tree, house};
            var pf = new ProductFilter();
            Console.WriteLine("Green products (old): ");

            foreach (var product in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {product.Name} is green");
            }
            
        }
    }
}