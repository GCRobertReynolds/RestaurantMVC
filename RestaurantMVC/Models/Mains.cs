﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMVC.Models
{
    public class Mains
    {
        public int MainsID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}