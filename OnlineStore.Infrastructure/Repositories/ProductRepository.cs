using Microsoft.EntityFrameworkCore;
using OnlineStore.Application.Interfaces;
using OnlineStore.Domain.Models;
using OnlineStore.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineStoeDbContext _context;
        public ProductRepository(OnlineStoeDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Product> GetAllAsync()
        {
            return _context.Products.AsNoTracking();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync( p => p.Id == id);
        }

        public async Task UpdateAsync(Product product)
        {
            var productToUpdate = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.Id);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Price = product.Price;
                productToUpdate.Stock = product.Stock;
                _context.Products.Update(productToUpdate);
               await _context.SaveChangesAsync();
            }
        }

    }
}
