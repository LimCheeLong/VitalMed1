using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace VitalMed.Shared.Domain
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Thumbnail { get; set; }
        public string Name { get; set; }
    }
}