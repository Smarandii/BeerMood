using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PIVANDEPOLA.Data.intefaces;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.Data.Repository
{
    public class CategoryRepository : IPivocategorii

    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> ALLcategories => appDBContent.Category;
    }
}
