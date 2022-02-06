using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalMed.Shared.Domain
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double ProductPrice { get; set;}
        [Required]
        public string ProductDesc { get; set; }
        public string ProductImage { get; set; }
        public virtual Category CategoryID { get; set; }
    }
}
