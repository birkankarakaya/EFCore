using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DAL
{
    public class ProductFeature
    {
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public int CreateUser { get; set; }        
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }
        public int ProductId { get; set; }        
    }
}
