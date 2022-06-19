using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC.MVC.Models
{
    public class ShippersView
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        [Display(Name = "Phone:")]
        public string Phone { get; set; }
        public string CompanyName { get; set; }
    }
}