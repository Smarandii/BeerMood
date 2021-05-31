using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.ViewModels
{
    public class PivosListViewModel
    {
        public IEnumerable<Pivo> allPivos {get;set;}
        public string currCategory { get; set; }

    }
}
