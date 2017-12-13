using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZarOH.Models
{
    public class Room
    {
        public int Id { get; set; }
        public RoomType RoomType { get; set; }
        public int RoomTypeId { get; set; }
    }
}