using Microsoft.AspNetCore.Mvc;
using RAD302Week3Lab12026CL.S00198790;

namespace ProductWebAPI2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _repository;

        public CustomersController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var customer = _repository.Get(id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _repository.Add(customer);
            return Ok(customer);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customer = _repository.Get(id);
            if (customer == null) return NotFound();

            _repository.Remove(customer);
            return Ok();
        }
    }
}