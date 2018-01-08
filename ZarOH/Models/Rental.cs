using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarOH.Models
{
    public class Rental
    {
        public int Id { get; set; }
        [Required]
        public Customer Customer { get; set;}
        [Required]
        public Room Room { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime ? DateLeft { get; set; }
    }
}