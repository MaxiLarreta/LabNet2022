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
            List<TransportePublico> CrearTransportes(string transporte, int cantidad)
            {
                List<TransportePublico> transportes = new List<TransportePublico> {};
                switch (transporte)
                {
                    case "Omnibus":
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                transportes.Add(new Omnibus(i + 10, i + 1));
                            };
                            return transportes;
                        }
                    case "Taxi":
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                transportes.Add(new Taxi(i + 1, i + 1));
                            };
                            return transportes;
                        }
                    default:
                        {
                            return transportes;
                        }
                }
            }

            List<TransportePublico> listaTransportes = CrearTransportes("Omnibus", 5).Concat(CrearTransportes("Taxi", 5)).ToList();

            foreach (TransportePublico transporte in listaTransportes)
            {
                Console.WriteLine($"{transporte.GetType().Name} {transporte.GetId()}: {transporte.GetPasajeros()} pasajeros.");
            }
            Console.ReadLine();
        }
    }
}
