using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using OrderWebApi.Data;
using OrderWebApi.Entities;

namespace OrderWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Orders3Controller : ControllerBase
    {
        private readonly IRepository<Order> _repository;

        public Orders3Controller(IRepository<Order> repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> Get()
        {
            var orders = await _repository.GetAll();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> Get(string id)
        {
            var order = await _repository.GetById(id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Create(Order dto)
        {
            await _repository.Insert(dto);
            return CreatedAtRoute("GetOrder", new { id = dto.Id.ToString() }, dto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Order dto)
        {
            var order = await _repository.GetById(dto.Id);
            if (order == null)
            {
                return NotFound();
            }
            await _repository.Update(dto);
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var order = await _repository.GetById(id);
            if (order == null)
            {
                return NotFound();
            }
            await _repository.Delete(id);
            return NoContent();
        }
    }
}

