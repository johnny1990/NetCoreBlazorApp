using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class Shipper
    {
        [Key]
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

    }
}
