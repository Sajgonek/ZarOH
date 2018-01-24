using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarOH.Dtos
{
    public class RoomDto
    {
        public int Id { get; set; }
        public RoomTypeDto RoomType { get; set; }
        [Required]
        public int RoomTypeId { get; set; }
        public bool IsOccupied { get; set; }
    }
}