using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.Data
{
    public class DBOjects
    {
        public static void Initial(AppDBContent content) 
        {
          
               

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Pivo.Any())
            {
                content.AddRange(new Pivo
                {
                    Name = "Балтика 9",
                    sopic = "Для настоящих мужчин",
                    Dopic = "после завода самое то ",
                    gradus = 9,
                    img = "/img/baltika.jpg",
                    isFavourite = true,
                    avalible = true,
                    price = 90,
                    Category = Categories["Алкогольное"]
                },


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
                    Category = Categories["Алкогольное"]
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
                    Category = Categories["Алкогольное"]
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
                    Category = Categories["Алкогольное"]
                }



                    );

            }
            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static  Dictionary<string,Category> Categories
        {
            get
            {
                if (category==null)
                {
                    var list = new Category[]
                    {
                        new Category {categoruName= "Алкогольное",opic= "Для настоящих мужчин" },
                        new Category{categoruName= "Безалкогольное",opic= "Для ненормальных людей"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoruName,el);
                }
                return category;
            }
        }
    }
}
