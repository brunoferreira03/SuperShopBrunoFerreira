using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SuperShopBrunoFerreira.Data.Entity;

namespace SuperShopBrunoFerreira.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }
    }
}
