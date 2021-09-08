using DesignPatterns.Enums;

namespace DesignPatterns.Classes
{
    public class Product
    {
        public Color Color;
        public string Name;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }
}