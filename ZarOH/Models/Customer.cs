﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZarOH.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter customer's Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Email Address.")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please enter Telephone Number.")]
        [Display(Name = "Telephone Number")]
        public string TelNr { get; set; }
        public MembershipType MembershipType { get; set; }
        [Required(ErrorMessage = "Please select customer's Membership Type.")]
        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }
        [Required]
        public bool WasACustomerBefore { get; set; }

    }
}