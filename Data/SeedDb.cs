using SuperShopBrunoFerreira.Data.Entity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShopBrunoFerreira.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private Random _random;

        public SeedDb(DataContext context)
        {
            _context = context;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            if (!_context.Products.Any())
            {
                AddProducts("iPhone X");
                AddProducts("iWatch 4");
                AddProducts("iPad Mini");
                await _context.SaveChangesAsync();
            }
        }

        private void AddProducts(string name)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(100)
            });
        }
    }
}
