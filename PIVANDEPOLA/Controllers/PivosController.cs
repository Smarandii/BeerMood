using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PIVANDEPOLA.Data.intefaces;
using PIVANDEPOLA.Data.Models;
using PIVANDEPOLA.ViewModels;

namespace PIVANDEPOLA.Controllers
{
    public class PivosController : Controller
    {
        private readonly Iallpivos _allPivos;
        private readonly IPivocategorii _allCategories;

        public PivosController(Iallpivos iAllpivos, IPivocategorii ipivocategorii)
        {
            _allPivos = iAllpivos;
            _allCategories = ipivocategorii;
        }
        [Route("Pivos/List")]
        [Route("Pivos/list/{category}")]
        public ViewResult List(string category)
           
        {
            string _category = category;
            IEnumerable<Pivo> pivos=null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                pivos = _allPivos.Pivos.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Alko", category, StringComparison.OrdinalIgnoreCase))
                {
                    pivos = _allPivos.Pivos.Where(i => i.Category.categoruName.Equals("Алкогольное")).OrderBy(i => i.id);
                    currCategory = "Алкогольное";
                }
                else if (string.Equals("UnAlko", category, StringComparison.OrdinalIgnoreCase))
                {
                    pivos = _allPivos.Pivos.Where(i => i.Category.categoruName.Equals("Безалкогольное")).OrderBy(i => i.id);
                    currCategory = "БезАлкогольное";
                }
               
                
            }
            var pivoObject = new PivosListViewModel
            {
                allPivos = pivos,
                currCategory = currCategory
            };
            ViewBag.Title = "Страница с певом";
          

            
            return View(pivoObject);
        }
    }
}
