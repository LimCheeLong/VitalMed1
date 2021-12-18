using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalMed.Shared.Domain
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public virtual CartItem Cart { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
