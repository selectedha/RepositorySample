using RepositorySamples.DAL;
using RepositorySamples.Domain.Categories;
using RepositorySamples.Domain.Products;
using RepositorySamples.Framework;

namespace RepositorySamples.API.Categories
{
    public class EfCategoryRepository : EfRepository<Category, RepSampleDBContext>, ICategoryRepository
    {
        public EfCategoryRepository(RepSampleDBContext dbContext) : base(dbContext)
        {

        }

        public void Add(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }
    }
}
