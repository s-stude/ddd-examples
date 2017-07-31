namespace WHAutomation_v1
{
    public class Product : IProduct
    {
        public Product(string name, ProductSize productSize)
        {
            Name = name;
            ProductSize = productSize;
        }

        public string Name { get; }
        public ProductSize ProductSize { get; }

        public override string ToString()
        {
            return $"Name: {Name}, ProductSize: {ProductSize}";
        }
    }
}