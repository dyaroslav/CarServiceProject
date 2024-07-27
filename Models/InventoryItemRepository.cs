namespace CarServiceProject.Models
{
    public class InventoryItemRepository: IInventoryItemRepository
    {
        private readonly CarServiceDbContext _carServiceDbContext;
        public InventoryItemRepository(CarServiceDbContext carServiceDbContext)
        {
            _carServiceDbContext = carServiceDbContext;
        }
        public IQueryable<InventoryItem> InventoryItems => _carServiceDbContext.InventoryItems;

        public IQueryable<InventoryItem> InventoryItemsOnSale => _carServiceDbContext.InventoryItems.Where(i => i.OnSale);
    }
}