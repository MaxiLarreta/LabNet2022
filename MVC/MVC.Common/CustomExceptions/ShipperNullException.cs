using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Common.CustomExceptions
{
    public class ShipperNullException : Exception
    {
        public ShipperNullException() : base("No se encontro ningun Shipper con ese ID")
        {

        }
    }
}
