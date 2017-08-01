using System.CodeDom;

namespace WHAutomations_v2
{
    public abstract class BasicSize
    {

    }

    public class SizeA : BasicSize
    {
        protected bool Equals(SizeA other)
        {
            return Volume == other.Volume;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SizeA) obj);
        }

        public override int GetHashCode()
        {
            return Volume;
        }

        public SizeA(int volume)
        {
            Volume = volume;
        }

        public int Volume { get; }
    }

    public class SizeC : BasicSize
    {
        protected bool Equals(SizeC other)
        {
            return Count == other.Count;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SizeC) obj);
        }

        public override int GetHashCode()
        {
            return Count;
        }

        public SizeC(int count)
        {
            Count = count;
        }

        public int Count { get; }
    }

    public class SizeB : BasicSize
    {
        protected bool Equals(SizeB other)
        {
            return Width == other.Width && Height == other.Height && Length == other.Length;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SizeB) obj);
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

        public SizeB(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public int Width { get; }
        public int Height { get; }
        public int Length { get; }
    }
}