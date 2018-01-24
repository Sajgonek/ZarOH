using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZarOH.Dtos;
using ZarOH.Models;
using System.Data.Entity;

namespace ZarOH.Controllers.API
{
    public class RoomsController : ApiController
    {
        private ApplicationDbContext _context;

        public RoomsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET api/customers
        public IHttpActionResult GetRooms(string query = null)
        {
            var roomsQuery = _context.Rooms
                .Include(r => r.RoomType);
                //.Where(r => r.IsOccupied == false);

            if (!String.IsNullOrWhiteSpace(query))
                roomsQuery = roomsQuery.Where(r => r.RoomType.Name.Contains(query));

            var roomDtos = roomsQuery
                .ToList()
                .Select(AutoMapper.Mapper.Map<Room, RoomDto>);

            return Ok(roomDtos);
        }

        //GET api/customer

        public IHttpActionResult GetRoom(int id)
        {
            var room = _context.Rooms.SingleOrDefault(c => c.Id == id);

            if (room == null)
                return NotFound();

            return Ok(AutoMapper.Mapper.Map<Room, RoomDto>(room));
        }

        //POST api/customers
        [Authorize(Roles = RoleName.CanManageRooms)]
        [HttpPost]
        public IHttpActionResult CreateRoom(RoomDto roomDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var room = AutoMapper.Mapper.Map<Room>(roomDto);

            _context.Rooms.Add(room);
            _context.SaveChanges();

            roomDto.Id = room.Id;

            return Created(new Uri(Request.RequestUri + "/" + room.Id), roomDto);
        }


        //PUT api/customers
        [Authorize(Roles = RoleName.CanManageRooms)]
        [HttpPut]
        public IHttpActionResult UpdateRoom(int id, RoomDto roomDto)
        {
            var roomInDb = _context.Rooms.Single(c => c.Id == roomDto.Id);

            if (roomInDb == null)
                return NotFound();

            AutoMapper.Mapper.Map(roomDto, roomInDb);

            _context.SaveChanges();

            return Ok(AutoMapper.Mapper.Map<Room, RoomDto>(roomInDb));
        }

        //DELETE api/customers/1
        [Authorize(Roles = RoleName.CanManageRooms)]
        [HttpDelete]
        public IHttpActionResult DeleteRoom(int id)
        {
            var roomInDb = _context.Rooms.Single(c => c.Id == id);

            if (roomInDb == null)
                return BadRequest();

            _context.Rooms.Remove(roomInDb);

            _context.SaveChanges();

            return Ok(AutoMapper.Mapper.Map<Room, RoomDto>(roomInDb));
        }
    }
}
