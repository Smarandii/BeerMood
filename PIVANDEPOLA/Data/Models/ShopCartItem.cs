using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIVANDEPOLA.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Pivo pivo { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }
    }
}
