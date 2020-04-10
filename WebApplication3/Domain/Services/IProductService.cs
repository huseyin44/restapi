using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Domain.Models;

namespace WebApplication3.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
