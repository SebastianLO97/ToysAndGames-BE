﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? AgeRestriction { get; set; }
        public decimal Price { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
