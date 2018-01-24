using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Web.Http;
using ZarOH.Dtos;
using ZarOH.Models;

namespace ZarOH.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET api/customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _context.Customers
                .Include(c => c.MembershipType);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.Name.Contains(query));

            var customerDtos = customersQuery
                .ToList()
                .Select(AutoMapper.Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);

        }

        //GET api/customer

        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(AutoMapper.Mapper.Map<Customer, CustomerDto>(customer));
        }

        //POST api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = AutoMapper.Mapper.Map<Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        //PUT api/customers
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            var customerInDb = _context.Customers.Single(c => c.Id == customerDto.Id);

            if (customerInDb == null)
                return NotFound();

            AutoMapper.Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();

            return Ok(AutoMapper.Mapper.Map<Customer, CustomerDto>(customerInDb));
        }

        //DELETE api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.Single(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);

            _context.SaveChanges();
        }
    }
}
