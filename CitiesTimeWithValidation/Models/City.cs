﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CitiesTimeWithValidation.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CurrentTime { get; set; }
    }
}