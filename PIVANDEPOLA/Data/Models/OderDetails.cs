using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIVANDEPOLA.Data.Models
{
    public class OderDetails
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int  PiboID { get; set; }
        public uint price { get; set; }
        public virtual Pivo pivo { get; set; }
        public virtual Order order  { get; set; }
        
    }
}
