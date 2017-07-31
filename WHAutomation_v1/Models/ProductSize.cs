namespace WHAutomation_v1
{
    public class ProductSize
    {
        public ProductSize(double amount, UnitOfMeasure unitOfMeasure)
        {
            Amount = amount;
            UnitOfMeasure = unitOfMeasure;
        }

        public double Amount { get; }
        public UnitOfMeasure UnitOfMeasure { get; }

        public override string ToString()
        {
            return $"Amount: {Amount}, UnitOfMeasure: {UnitOfMeasure}";
        }
    }
}