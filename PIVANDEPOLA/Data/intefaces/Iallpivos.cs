using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.Data.intefaces
{
    public interface Iallpivos
    {

        IEnumerable<Pivo> Pivos { get; }
        IEnumerable<Pivo> GetFavPivos { get;  }
        Pivo getObjectPivo(int pivoid);


    }
}
