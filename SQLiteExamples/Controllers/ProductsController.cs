using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLiteExamples.Data;
using SQLiteExamples.Entities;

namespace SQLiteExamples.Controllers
{


    [Route("api/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

            _dbContext.Database.EnsureCreated();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            _dbContext.Products.Add(product);

            _dbContext.SaveChanges();
            return Ok("Ürün başarıyla eklendi.");
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _dbContext.Products.ToList();

            return Ok(products);
        }
    }
}
