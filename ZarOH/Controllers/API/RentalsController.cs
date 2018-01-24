using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using ZarOH.Dtos;
using ZarOH.Models;

namespace ZarOH.Controllers.API
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IHttpActionResult GetRentals()
        {
            var rentals = _context.Rentals
                .Include(c => c.Customer)
                .Include(r => r.Room)
                .Include(r => r.Room.RoomType);

            var rentalsDtos = rentals.ToList().Select(AutoMapper.Mapper.Map<Rental, RentalDto>);

            return Ok(rentalsDtos);
        }

        //[HttpDelete]
        //public IHttpActionResult DeleteRental(int id)
        //{
        //    var rentalInDb = _context.Rentals.Include(r=>r.Room).Single(r => r.Id == id);          

        //    if (rentalInDb != null)
        //    {
        //        rentalInDb.Room.IsOccupied = false;


        //        _context.Rentals.Remove(rentalInDb);
        //    }

        //    _context.SaveChanges();

        //    return Ok();
        //}

        //[HttpPut]
        //public IHttpActionResult UpdateRental(int id, RentalDto rentalDto)
        //{
        //    var rentalInDb = _context.Rentals
        //        //.Include(r => r.Room)
        //        //.Include(c=>c.Customer)
        //        .Single(r => r.Id == id);

        //    if (rentalInDb == null)
        //        return NotFound();

        //    AutoMapper.Mapper.Map(rentalDto, rentalInDb);

        //    _context.SaveChanges();

        //    return Ok(AutoMapper.Mapper.Map<Rental, RentalDto>(rentalInDb));
        //}



    }
}
