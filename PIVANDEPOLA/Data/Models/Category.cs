using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIVANDEPOLA.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoruName { set; get; }
        public string opic { set; get; }
        public List<Pivo> pivos { set; get; }




    }
}
