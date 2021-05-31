using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pivo> favpivos { get; set; }
    }
}
