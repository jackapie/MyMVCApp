﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCApp.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
    }
}