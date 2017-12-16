using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarOH.Models
{
    public class Room
    {
        public int Id { get; set; }
        public RoomType RoomType { get; set; }
        [Required]
        [Display(Name ="Type of the Room")]
        public int RoomTypeId { get; set; }
    }
}