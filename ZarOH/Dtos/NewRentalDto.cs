﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZarOH.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> RoomIds { get; set; }
    }
}