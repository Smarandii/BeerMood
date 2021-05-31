using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PIVANDEPOLA.Data.intefaces;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.Data.mocks
{
    public class MockCategory : IPivocategorii
    {
        public IEnumerable<Category> ALLcategories 
        {
            get 
            {
                return new List<Category>
                { 
                  new Category {categoruName= "Алкогольное",opic= "Для настоящих мужчин" },
                  new Category{categoruName= "Безалкогольное",opic= "Для ненормальных людей"}
                };
            }
        
        
        }
    }
}
