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
    public class HomeController:Controller
    {
        private readonly Iallpivos _pivoRep;
  


        public HomeController(Iallpivos pivoRep)
        {
            _pivoRep = pivoRep;
    

        }
        public ViewResult Index()
        {
            var homePivos = new HomeViewModel
            {
                favpivos = _pivoRep.GetFavPivos
            };
            return View(homePivos);
        }
    }
}
