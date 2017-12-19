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
        [Required]
        public int RoomTypeId { get; set; }
    }
}