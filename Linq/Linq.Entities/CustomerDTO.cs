using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Entities
{
    public class CustomerDTO
    {
     
        public string Region { get; set; }

        public DateTime? OrderDate { get; set; }

    }
}
