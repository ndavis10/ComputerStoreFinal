using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComputerStoreFinal.Models
{
    public class Part
    {
        [Required]
        [Display(Name= "Part Number")]
        public int PartID { get; set; }
        [Required]
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }
        [Display(Name = "Model Number")]
        public string ModelNumber { get; set; }
        [Display(Name = "Name")]
        public string PartName { get; set; }
        [Display(Name = "Description")]
        public string PartDescription { get; set; }
        [Display(Name = "Retail Price")]
        public decimal PartPrice { get; set; }
        [Display(Name = "Image URL")]
        public string PartImg { get; set; }
    }
}