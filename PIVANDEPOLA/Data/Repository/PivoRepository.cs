using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PIVANDEPOLA.Data.intefaces;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.Data.Repository
{
    public class PivoRepository : Iallpivos
    {
        private readonly AppDBContent appDBContent;
        public PivoRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Pivo> Pivos => appDBContent.Pivo.Include(c => c.Category);

        public IEnumerable<Pivo> GetFavPivos => appDBContent.Pivo.Where(p => p.isFavourite).Include(c => c.Category);

        public Pivo getObjectPivo(int pivoid) => appDBContent.Pivo.FirstOrDefault(p => p.id == pivoid);
       
    }
}
