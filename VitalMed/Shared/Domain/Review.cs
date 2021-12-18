using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalMed.Shared.Domain
{
    public class Review
    {
        public int ID { get; set; }
        public string ReviewDesc { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
