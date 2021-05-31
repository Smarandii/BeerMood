using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PIVANDEPOLA.Data.intefaces;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.Data.mocks
{
    public class MockPivo : Iallpivos
    {

        private readonly IPivocategorii _categorypivos = new MockCategory();

        public IEnumerable<Pivo> Pivos 
        {
            get
            {
                return new List<Pivo>
                { new Pivo{
                    Name= "Балтика 9",
                    sopic= "Для настоящих мужчин",
                    Dopic="после завода самое то ",
                    gradus=9,
                    img="/img/baltika.jpg",
                    isFavourite=true,
                    avalible=true,
                    price=90,
                    Category=_categorypivos.ALLcategories.First()},


                new Pivo
                {
                    Name = "hoegaarden",
                    sopic = "Для настоящих мужчин",
                    Dopic = "после завода самое то ",
                    gradus = 8,
                    img = "/img/hoegaarden.jpg",
                    isFavourite = true,
                    avalible = true,
                    price = 90,
                    Category = _categorypivos.ALLcategories.First()
                },
                new Pivo
                {
                    Name = "essa",
                    sopic = "Для баб",
                    Dopic = "нахуй вы это пьете  ",
                    gradus = 6,
                    img = "/img/essa.jpg",
                    isFavourite = true,
                    avalible = true,
                    price = 90,
                    Category = _categorypivos.ALLcategories.First()
                },
                new Pivo
                { 
                    Name = "garage",
                    sopic = "Для конченных баб ",
                    Dopic = "ваще пидец сказать нечего просто  ",
                    gradus = 4,
                    img = "/img/garage.jpg",
                    isFavourite = true,
                    avalible = true,
                    price = 90,
                    Category = _categorypivos.ALLcategories.First()
                }




                };
                
            }

        }
        public IEnumerable<Pivo> GetFavPivos { get; set ; }

        public Pivo getObjectPivo(int pivoid)
        {
            throw new NotImplementedException();
        }
    }
}
