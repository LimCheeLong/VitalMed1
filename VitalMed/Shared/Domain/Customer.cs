using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalMed.Shared.Domain
{
    public class Customer
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public string Email { get; set; }
        public virtual CartItem Cart { get; set; }
    }
}
