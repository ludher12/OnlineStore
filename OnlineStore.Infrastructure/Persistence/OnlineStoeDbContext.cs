using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructure.Persistence
{
    public class OnlineStoeDbContext : DbContext
    {
        public OnlineStoeDbContext(DbContextOptions<OnlineStoeDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Curso> Cursos { get; set; }
    }
}
