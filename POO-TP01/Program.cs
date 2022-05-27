using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP01
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<TransportePublico> CrearTransportes<T>(int cantidad) where T : TransportePublico
            {
                List<TransportePublico> transportes = new List<TransportePublico> { };

                for (int i = 0; i < cantidad; i++)
                {
                    transportes.Add(
                        (T)Activator.CreateInstance(
                            typeof(T), new Object[] { i + 10, i + 1 }
                        )
                    );
                }
                return transportes;

            }

            List<TransportePublico> listaTransportes = CrearTransportes<Omnibus>(5).Concat(CrearTransportes<Taxi>(5)).ToList();

            foreach (TransportePublico transporte in listaTransportes)
            {
                Console.WriteLine($"{transporte.GetType().Name} {transporte.GetId()}: {transporte.GetPasajeros()} pasajeros.");
            }
            Console.ReadLine();
        }
    }
}
