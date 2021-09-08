namespace DesignPatterns
{
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == size;
        }
    }
}