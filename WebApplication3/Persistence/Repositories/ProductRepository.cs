using Microsoft.EntityFrameworkCore;
using Supermarket.API.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Domain.Models;
using WebApplication3.Domain.Repositories;
using WebApplication3.Persistence.Contexts;

namespace WebApplication3.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category)
                                          .ToListAsync();
        }
    }
}
