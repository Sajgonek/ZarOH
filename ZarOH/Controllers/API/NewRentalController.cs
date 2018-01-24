using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZarOH.Dtos;
using ZarOH.Models;

namespace ZarOH.Controllers.API
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }


        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            var room = _context.Rooms.Single(m => m.Id == newRental.RoomId);


                if (!room.IsOccupied == false)
                    return BadRequest("This room is already occupied at the moment");
                room.IsOccupied = true;
                var rental = new Rental
                {
                    Customer = customer,
                    Room = room,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            _context.SaveChanges();


            return Ok();
        }


    }
}
