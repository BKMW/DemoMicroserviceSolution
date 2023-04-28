using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using OrderWebApi.Data;
using OrderWebApi.Entities;

namespace OrderWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Orders2Controller : ControllerBase
    {
        private readonly IContext _context;

        public Orders2Controller(IContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> Get()
        {
            var orders = await _context.Orders.Find(order => true).ToListAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> Get(string id)
        {
            var order = await _context.Orders.Find(o => o.Id == id).FirstOrDefaultAsync();
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Create(Order dto)
        {
            await _context.Orders.InsertOneAsync(dto);
            return CreatedAtRoute("GetOrder", new { id = dto.Id.ToString() }, dto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Order dto)
        {
            var order = await _context.Orders.Find<Order>(x => x.Id == dto.Id).FirstOrDefaultAsync();
            if (order == null)
            {
                return NotFound();
            }
            await _context.Orders.ReplaceOneAsync(x => x.Id == dto.Id, dto);
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var order = await _context.Orders.Find<Order>(o => o.Id == id).FirstOrDefaultAsync();
            if (order == null)
            {
                return NotFound();
            }
            await _context.Orders.DeleteOneAsync(o => o.Id == id);
            return NoContent();
        }
    }
}

