using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DAL
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Barcode { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
