using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class CustomerDemographic
    {
        [Key]
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
    }
}
