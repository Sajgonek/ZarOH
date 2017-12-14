using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZarOH.Models;

namespace ZarOH.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        public string Name
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return "Edit Customer";

                return "New Customer";
            }
        }
    }
}