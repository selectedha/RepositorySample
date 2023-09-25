

using RepositorySamples.Domain.Products;
using RepositorySamples.Framework;

namespace RepositorySamples.DAL.Products
{
    public class EfProductRepository : EfRepository<Product, RepSampleDBContext>, IProductRepository
    {
        public EfProductRepository(RepSampleDBContext dbContext) : base(dbContext)
        {
        }

        public void Add(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }
    }
}
