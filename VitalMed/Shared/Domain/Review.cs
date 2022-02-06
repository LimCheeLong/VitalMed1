using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalMed.Shared.Domain
{
    public class Review
    {   [Required]
        public string Name { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Rating { get; set; }
        public int ID { get; set; }
        [Required]
        public string ReviewDesc { get; set; }
     
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
