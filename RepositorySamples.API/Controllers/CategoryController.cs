using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositorySamples.API.Categories;
using RepositorySamples.Domain.Categories;
using RepositorySamples.Domain.Common;

namespace RepositorySamples.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepositorySampleDomainUnitOfWork _uow;
        private ICategoryRepository _categoryRepository;

        public CategoryController(IRepositorySampleDomainUnitOfWork uow, ICategoryRepository categoryRepository)
        {
            _uow = uow;
            _categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(string title)
        {
            var category = new Category(title);
            _uow.BeginTransaction();
            _categoryRepository.Add(category);
            _uow.CommitTransaction();
            return Ok(category);
        }
    }
}
