using Microsoft.AspNetCore.Identity;
using SuperShopBrunoFerreira.Data.Entity;
using SuperShopBrunoFerreira.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShopBrunoFerreira.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private Random _random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUserByEmailAsync("bff3rreira03@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Bruno",
                    LastName = "Ferreira",
                    Email = "bff3rreira03@gmail.com",
                    UserName = "bff3rreira03@gmail.com",
                    PhoneNumber = "1234567890",
                };

                var result = await _userHelper.AddUserAsycn(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in the seeder");
                }
            }

            if (!_context.Products.Any())
            {
                AddProducts("iPhone X", user);
                AddProducts("iWatch 4", user);
                AddProducts("iPad Mini", user);
                await _context.SaveChangesAsync();
            }
        }

        private void AddProducts(string name, User user)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(100),
                User = user
            });
        }
    }
}
