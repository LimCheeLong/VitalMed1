using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalMed.Shared.Domain
{
    public class Favourite
    {
        public int ID { get; set; }
        public virtual Product Product{ get; set; }
        public virtual Customer Customer { get; set; }
    }
}
