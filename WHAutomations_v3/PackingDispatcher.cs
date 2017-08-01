namespace WHAutomations_v3
{
    public class PackingDispatcher
    {
        private readonly IPackingLineCoordinator _packingLineCoordinator;

        public PackingDispatcher(IPackingLineCoordinator packingLineCoordinator)
        {
            _packingLineCoordinator = packingLineCoordinator;
        }

        public IPackedProduct PackProduct(IProduct product)
        {
            var line = _packingLineCoordinator.GetPackingLineBy(product);

            var packedProduct = line.Pack(product);

            return packedProduct;
        }
    }
}