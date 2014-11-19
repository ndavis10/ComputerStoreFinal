using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerStoreFinal.Models
{
    public class OrderPart
    {
        public int OrderPartID { get; set; }
        public int Order { get; set; }
        public int PartID { get; set; }
        public int Quantity { get; set; }
        public decimal PartPrice { get; set; }
        public virtual Part Part { get; set; }
        public virtual Order Order { get; set; }
    }
}