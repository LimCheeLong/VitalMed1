using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalMed.Shared.Domain
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set;}
        public string ProductDesc { get; set; }
        public string ProductImage { get; set; }
        public virtual Category Category { get; set; }
    }
}
