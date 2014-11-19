using ComputerStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ComputerStoreFinal.DataContexts
{
    public class ComputerStoreDb : DbContext
    {
        public ComputerStoreDb() : base("DefaultConnection") { }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPart> OrderParts { get; set; }
        public DbSet<ComputerStoreFinal.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}