using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PIVANDEPOLA.Data.Models;

namespace PIVANDEPOLA.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        { }

        public DbSet<Pivo> Pivo{get;set;}
        public DbSet<Category> Category { get; set; }

        public DbSet<ShopCartItem> ShopCartItems { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<OderDetails> OrderDetails  { get; set; }

    }
}
