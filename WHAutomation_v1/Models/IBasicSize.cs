namespace WHAutomation_v1
{
    public interface IBasicSize<T>
    {
        UnitOfMeasure UnitOfMeasure { get; set; }
        bool FitProductSize(T productSize);
    }

    public class PieceSize : IBasicSize<PieceProductSize>
    {
        public PieceSize(UnitOfMeasure unitOfMeasure)
        {
            UnitOfMeasure = unitOfMeasure;
            Count = 1;
        }

        public int Count { get; set; }

        public UnitOfMeasure UnitOfMeasure { get; set; }

        public bool FitProductSize(PieceProductSize productSize)
        {
            return Count == productSize.Count;
        }
    }

    public class LiquidsSize : IBasicSize<LiquidProductSize>
    {
        public LiquidsSize(UnitOfMeasure unitOfMeasure, double volume)
        {
            UnitOfMeasure = unitOfMeasure;
            Volume = volume;
        }

        public double Volume { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }

        public bool FitProductSize(LiquidProductSize productSize)
        {
            return Volume == productSize.Volume;
        }
    }

    public class ThreeDSize : IBasicSize<ThreeDProductSize>
    {
        public ThreeDSize(UnitOfMeasure unitOfMeasure, int width, int length, int height)
        {
            UnitOfMeasure = unitOfMeasure;
            Width = width;
            Length = length;
            Height = height;
        }

        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }

        public UnitOfMeasure UnitOfMeasure { get; set; }

        public bool FitProductSize(ThreeDProductSize productSize)
        {
            return Width == productSize.Width && Height == productSize.Height && Length == productSize.Length;
        }
    }
}