using SuperShopBrunoFerreira.Data.Entity;
using SuperShopBrunoFerreira.Models;

namespace SuperShopBrunoFerreira.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductsViewModel model, string path, bool isNew);

        ProductsViewModel ToProductViewModel(Product product);
    }
}
