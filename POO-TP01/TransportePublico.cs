using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP01
{
    public abstract class TransportePublico
    {
        private int pasajeros;
        private readonly int id;

        public TransportePublico(int pasajeros, int id)
        {
            this.pasajeros = pasajeros;
            this.id = id;
        }

        public int GetPasajeros()
        {
           return this.pasajeros;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetPasajeros(int cantidad)
        {
            this.pasajeros = cantidad;
        }

        public abstract string Avanzar();
        public abstract string Detenerse();

    }
}
