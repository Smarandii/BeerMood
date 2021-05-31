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
    public class ShopCartController : Controller
    {
        private readonly Iallpivos _pivoRep;
        private readonly ShopCart _shopCart;


        public ShopCartController(Iallpivos pivoRep,ShopCart shopCart)
        { 
            _pivoRep = pivoRep;
            _shopCart = shopCart;

        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;
            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id )
        {
            var item = _pivoRep.Pivos.FirstOrDefault(i => i.id==id);
            if (item!=null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
