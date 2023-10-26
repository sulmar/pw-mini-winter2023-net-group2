using Microsoft.AspNetCore.Mvc;
using Domain.Model;
using Domain.Abstractions;

namespace Api.Customers
{
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository repository;

        public CustomersController(ICustomerRepository repository)
        {
            this.repository = repository;
        }

        // GET api/customers

        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "John", LastName = "Smith"},
                new Customer { Id = 2, FirstName = "Bob", LastName = "Smith"},
                new Customer { Id = 3, FirstName = "Kate", LastName = "Smith"},
            };

            return Ok(customers);
        }
    }
    
}
