using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalMed.Shared.Domain
{
    public class CartItem
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int ProductQuantity { get; set; }
        public virtual Product Product { get; set; }
    }
}
