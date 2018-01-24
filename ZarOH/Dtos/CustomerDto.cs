using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ZarOH.Models;

namespace ZarOH.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter customer's Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Email Address.")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please enter Telephone Number.")]
        [Display(Name = "Telephone Number")]
        public string TelNr { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
        [Required(ErrorMessage = "Please select customer's Membership Type.")]
        public int MembershipTypeId { get; set; }
        [Required]
        public bool WasACustomerBefore { get; set; }
    }
}