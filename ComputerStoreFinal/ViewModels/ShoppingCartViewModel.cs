using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComputerStoreFinal.Models;

namespace ComputerStoreFinal.ViewModels
{
    public class ShoppingCartViewModel
    {
        public int ID { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}