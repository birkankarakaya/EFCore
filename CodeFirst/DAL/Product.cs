using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DAL
{
    public class Product
    {
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public int CreateUser { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }        
        public int Stock { get; set; }
        public string Barcode { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }
        public decimal Kdv { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal PriceKdv { get; set; }
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
