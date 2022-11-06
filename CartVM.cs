using SubhashTripathi_Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SubhashTripathi_Demo
{
    public class CartVM
    {
        [Key]
        public int id { get; set; }
        public Product product { get; set; }

    }
}