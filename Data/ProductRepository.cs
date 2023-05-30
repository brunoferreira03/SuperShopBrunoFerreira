using SuperShopBrunoFerreira.Data.Entity;

namespace SuperShopBrunoFerreira.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {

        }
    }
}
