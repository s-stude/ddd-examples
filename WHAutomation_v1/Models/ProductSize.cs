using System.Threading;

namespace WHAutomation_v1
{
    public abstract class ProductSize
    {
        public UnitOfMeasure UnitOfMeasure { get; protected set; }
    }

    public class PieceProductSize : ProductSize
    {
        public PieceProductSize(UnitOfMeasure unitOfMeasure)
        {
            Count = 1;
        }

        public int Count { get; set; }
    }

    public class LiquidProductSize : ProductSize
    {
        public LiquidProductSize(double volume, UnitOfMeasure unitOfMeasure)
        {
            UnitOfMeasure = unitOfMeasure;
            Volume = volume;
        }

        public double Volume { get; }
    }

    public class ThreeDProductSize : ProductSize
    {
        public ThreeDProductSize(double weight, int width, int length, int height, UnitOfMeasure unitOfMeasure)
        {
            Weight = weight;
            Width = width;
            Length = length;
            Height = height;
            UnitOfMeasure = unitOfMeasure;
        }

        public double Weight { get; set; }

        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
    }
}