using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductWebApi.Models;

namespace ProductWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductDbContext _dbContext;

        public ProductsController(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product> >Get()
        {
            return _dbContext.Products;
        }

        [HttpGet("{id:int}")]
        public async Task <ActionResult<Product>> GetById(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            return product;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Product product)
        {
             await _dbContext.AddAsync(product);
            var result= await _dbContext.SaveChangesAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Product product)
        {
             _dbContext.Update(product);
            var result = await _dbContext.SaveChangesAsync();
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            _dbContext.Products.Remove(product);
            var result = await _dbContext.SaveChangesAsync();
            return Ok(result);
        }


    }
}
