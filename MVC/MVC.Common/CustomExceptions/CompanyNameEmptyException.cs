using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Common.CustomExceptions
{
    public class CompanyNameEmptyException : Exception
    {
        public CompanyNameEmptyException() : base("Ingreso un nombre vacío")
        {
        }
    }
}
