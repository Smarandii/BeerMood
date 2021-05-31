using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIVANDEPOLA.Data.Models
{
    public class Pivo
    {
        public int id { set; get; }
       
        public int gradus { set; get; }
        public string Name { set; get; }
        public string sopic { set; get; }

        public string Dopic { set; get; }

        public string img { set; get; }
        public ushort price { set; get; }

        public bool isFavourite { set; get; }

        public bool avalible { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }









    }
}
