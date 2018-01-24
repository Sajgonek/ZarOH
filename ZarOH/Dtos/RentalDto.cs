using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ZarOH.Models;

namespace ZarOH.Dtos
{
    public class RentalDto
    {
        public int Id { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public Room Room { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateLeft { get; set; }
    }
}