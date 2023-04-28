using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using OrderWebApi.Entities;

namespace OrderWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Orders1Controller : ControllerBase
    {
        private readonly IMongoCollection<Order> _orders;

        public Orders1Controller(
            IMongoClient client
            )
        {
            _orders = client.GetDatabase("dms-order").GetCollection<Order>("Order");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> Get()
        {
            var orders = await _orders.Find(order => true).ToListAsync();
            return Ok(orders);
        }

        [HttpGet("{id:length(24)}", Name = "GetOrder")]
        public async Task<ActionResult<Order>> Get(string id)
        {
            var order = await _orders.Find<Order>(x=>x.Id == id).FirstOrDefaultAsync();
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Create(Order order)
        {
            await _orders.InsertOneAsync(order);
            return CreatedAtRoute("GetOrder", new { id = order.Id.ToString() }, order);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Order orderIn)
        {
            var order = await _orders.Find<Order>(x=>x.Id == id).FirstOrDefaultAsync();
            if (order == null)
            {
                return NotFound();
            }
            await _orders.ReplaceOneAsync(x=>x.Id == id, orderIn);
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var order = await _orders.Find<Order>(x=>x.Id == id).FirstOrDefaultAsync();
            if (order == null)
            {
                return NotFound();
            }
            await _orders.DeleteOneAsync(x=>x.Id == id);
            return NoContent();
        }
    }
}