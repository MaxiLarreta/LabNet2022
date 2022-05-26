using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP01
{
    internal class Taxi : TransportePublico
    {
        public Taxi(int pasajeros, int id) : base(pasajeros, id)
        {
        }

        public override string Avanzar()
        {
            return $"Estoy avanzando como un Taxi";
        }

        public override string Detenerse()
        {
            return $"Estoy deteniendome como un Taxi";
        }
    }
}
