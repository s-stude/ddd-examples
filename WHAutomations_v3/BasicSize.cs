namespace WHAutomations_v3
{
    public abstract class BasicSize
    {
        public override string ToString()
        {
            return $"";
        }
    }

    public class LiquidsSize : BasicSize
    {
        protected bool Equals(LiquidsSize other)
        {
            return Volume == other.Volume;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((LiquidsSize) obj);
        }

        public override int GetHashCode()
        {
            return Volume;
        }

        public LiquidsSize(int volume)
        {
            Volume = volume;
        }

        public int Volume { get; }

        public override string ToString()
        {
            return $"Volume: {Volume}";
        }
    }

    public class PiecesSize : BasicSize
    {
        protected bool Equals(PiecesSize other)
        {
            return Count == other.Count;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PiecesSize) obj);
        }

        public override int GetHashCode()
        {
            return Count;
        }

        public PiecesSize(int count)
        {
            Count = count;
        }

        public int Count { get; }

        public override string ToString()
        {
            return $"Count: {Count}";
        }
    }

    public class GrosserySize : BasicSize
    {
        protected bool Equals(GrosserySize other)
        {
            return Width == other.Width && Height == other.Height && Length == other.Length;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((GrosserySize) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Width;
                hashCode = (hashCode*397) ^ Height;
                hashCode = (hashCode*397) ^ Length;
                return hashCode;
            }
        }

        public GrosserySize(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public int Width { get; }
        public int Height { get; }
        public int Length { get; }

        public override string ToString()
        {
            return $"Width: {Width}, Height: {Height}, Length: {Length}";
        }
    }
}