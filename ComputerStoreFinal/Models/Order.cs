using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerStoreFinal.Models
{
    public partial class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShipAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ShippingTotal { get; set; }
        public decimal SalesTax { get; set; }
        public System.DateTime OrderDate { get; set;}
        public List<OrderPart> OrderPart { get; set; }

    }
}