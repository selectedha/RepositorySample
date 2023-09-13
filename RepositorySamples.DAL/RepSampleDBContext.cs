using Microsoft.EntityFrameworkCore;
using RepositorySamples.Domain.Categories;
using RepositorySamples.Domain.Products;
using RepositorySamples.Framework;

namespace RepositorySamples.DAL
{
    public class RepSampleDBContext : BaseDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public RepSampleDBContext(DbContextOptions<RepSampleDBContext> options) : base(options)
        {
        }
    }
}