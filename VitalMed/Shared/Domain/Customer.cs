using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalMed.Shared.Domain
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int ContactNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual CartItem Cart { get; set; }
    }
}
