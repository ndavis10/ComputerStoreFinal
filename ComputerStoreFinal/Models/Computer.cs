using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerStoreFinal.Models
{
    public class Computer
    {
        public int ComputerID { get; set; }
        public int PartID { get; set; }
        public string ComputerName { get; set; }
        public decimal ComputerPrice { get; set; }
        public string ComputerImg { get; set; }


    }
}