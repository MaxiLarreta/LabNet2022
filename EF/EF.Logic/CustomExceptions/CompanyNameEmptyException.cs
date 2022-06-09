using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logic.CustomExceptions
{
    internal class CompanyNameEmptyException : Exception
    {
        public CompanyNameEmptyException() : base("Ingreso un nombre vacío")
        {
        }
    }
}
