﻿using Microsoft.EntityFrameworkCore;
using SuperShopBrunoFerreira.Data.Entity;
using System.Linq;

namespace SuperShopBrunoFerreira.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable GetAllWithUsers()
        {
            return _context.Products.Include(p => p.User);
        }
    }
}
