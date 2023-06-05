using SuperShopBrunoFerreira.Data.Entity;
using System.Linq;

namespace SuperShopBrunoFerreira.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();
    }
}
