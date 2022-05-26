using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP01
{
    internal class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros, int id) : base(pasajeros, id)
        {
        }

        public override string Avanzar()
        {
            return "Estoy avanzando como un Ómnibus";
        }

        public override string Detenerse()
        {
            return "Me estoy deteniendo como un Ómnibus";
        }
    }
}
