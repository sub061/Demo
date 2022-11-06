using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SubhashTripathi_Demo.Models
{
    [Table("product")]
    public class Product
    {

        [Key]
        public int id { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Price")]
        public double price { get; set; }
        [Display(Name = "Image")]
        public string image { get; set; }
        
        public bool? isDeleted { get; set; } 

    }
}