using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ShippersModelPut
    {
        [Key]
        public int ShipperID { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }
    }
}