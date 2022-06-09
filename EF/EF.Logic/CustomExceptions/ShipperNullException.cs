using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logic.CustomExceptions
{
    internal class ShipperNullException : Exception
    {
        public ShipperNullException() : base("No se encontro ningun Shipper con ese ID")
        {

        }
    }
}
