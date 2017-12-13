using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarOH.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public MembershipType MembershipType { get; set; }
        [Required]
        public int MembershipTypeId { get; set; }
        [Required]
        public bool WasACustomerBefore { get; set; }

    }
}