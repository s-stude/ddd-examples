using System;

namespace WHAutomation_v1
{
    public interface IPackedProduct
    {
        IProduct Product { get; }
        IPackage Package { get; }
        DateTime PackedOn { get; }
        string PackedBy { get; }
    }
}