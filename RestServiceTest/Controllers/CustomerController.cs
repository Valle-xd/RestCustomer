using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace RestServiceTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static List<Customer> cList = new List<Customer>
        {
            new Customer(1, "Knud", "dunk", 2019),
            new Customer(2, "Jon", "Hansen", 2012),
            new Customer(3, "Martin", "Rydahl", 2020)

        };

    // GET: api/Customer
        [HttpGet]
        public List<Customer> Get()
        {
            return cList;
        }

        // GET: api/Customer/
        [HttpGet("{id}", Name = "Get")]
        public Customer GetId(int id)
        {
            foreach (Customer customer in cList)
            {
                if (id == customer.Id)
                {
                    return customer;
                }
            }
            //throw new ArgumentException("can't find id"); vil få programmmet til at lukke, hvis man taster forkert id
            return null;
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            cList.Add(customer);
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer customer)
        {
            
            foreach (Customer listCustomer in cList)
            {
                if (id == listCustomer.Id)
                {
                    cList.Remove(listCustomer);
                    cList.Add(customer);
                    return;
                }
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Customer listCustomer in cList)
            {
                if (id == listCustomer.Id)
                {
                    cList.Remove(listCustomer);
                    return;
                }
            }
        }
    }
}
