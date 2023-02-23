﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DAL
{
    public class Category
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set;} = new List<Product>();
    }
}
