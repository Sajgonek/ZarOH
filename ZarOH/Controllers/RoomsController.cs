using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using ZarOH.Models;
using ZarOH.ViewModels;

namespace ZarOH.Controllers
{
    public class RoomsController : Controller
    {
        ApplicationDbContext _context;
        public RoomsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddRoom()
        {
            var roomtypes = _context.RoomTypes.ToList();
            var viewModel = new RoomFormViewModel
            {
                Room = new Room(),
                RoomTypes = roomtypes
            };
            return View("RoomForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var room = _context.Rooms.SingleOrDefault(c => c.Id == id);

            if (room == null)
                return HttpNotFound();

            var viewModel = new RoomFormViewModel
            {
                Room = room,
                RoomTypes = _context.RoomTypes.ToList()
            };

            return View("RoomForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Room room)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new RoomFormViewModel
                {
                    Room = room,
                    RoomTypes = _context.RoomTypes.ToList()
                };
                return View("RoomForm", viewModel);
            }

            if (room.Id == 0)
                _context.Rooms.Add(room);
            else
            {
                var roomInDb = _context.Rooms.Single(c => c.Id == room.Id);
                roomInDb.RoomTypeId = room.RoomTypeId;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Rooms");
        }


    }
}