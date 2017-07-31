namespace WHAutomation_v1
{
    public class PackageSize
    {
        public PackageSize(UnitOfMeasure unitOfMeasure, double volume)
        {
            UnitOfMeasure = unitOfMeasure;
            Volume = volume;
        }

        public double Volume { get; }
        public UnitOfMeasure UnitOfMeasure { get; }

        public override string ToString()
        {
            return $"Volume: {Volume}, UnitOfMeasure: {UnitOfMeasure}";
        }
    }
}