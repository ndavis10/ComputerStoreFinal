using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerStoreFinal.Models
{
    public class Part
    {
        public int PartID { get; set; }
        public int CategoryID { get; set; }
        public int ModelNumber { get; set; }
        public string PartName { get; set; }
        public string PartDescription { get; set; }
        public decimal PartPrice { get; set; }
        public string PartImg { get; set; }
        public Category Category { get; set; }
    }
}