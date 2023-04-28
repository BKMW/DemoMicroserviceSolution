using Customer.Application.Interfaces;
using Customer.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public CustomersController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult> GetCustomers()
        {
            if (_context.Repository<Client>() == null)
            {
                return NotFound();
            }

            var clients= await _context.Repository<Client>().ListAllAsync();
            return Ok(clients);
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetCustomer(int id)
        {
            if (await _context.Repository<Client>().ListAllAsync() == null)
            {
                return NotFound();
            }
            var customer = await _context.Repository<Client>().GetByIdAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(Client dto)
        {



            try
            {
                var client = await _context.Repository<Client>().GetByIdAsync(dto.CustomerId);
                if(client == null)
                {
                    return NotFound();
                }
                client.MobileNumber = dto.MobileNumber;
                await _context.Complete();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return NoContent();
        }

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Client>> PostCustomer(Client customer)
        {
            try
            {
                _context.Repository<Client>().Add(customer);
                await _context.Complete();

                return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);

            }catch(Exception ex)
            {
                return BadRequest(ex);
            }
           
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            
            var customer = await _context.Repository<Client>().GetByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Repository<Client>().Delete(customer);
            await _context.Complete();

            return NoContent();
        }

        //private bool CustomerExists(int id)
        //{
        //    return (_context.Repository<Client>()?.GetByIdAsync(id)).GetValueOrDefault();
        //}
    }
}
