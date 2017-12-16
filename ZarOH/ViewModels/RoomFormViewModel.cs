using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZarOH.Models;

namespace ZarOH.ViewModels
{
    public class RoomFormViewModel
    {
        public IEnumerable<RoomType> RoomTypes { get; set; }
        public Room Room { get; set; }
    }
}