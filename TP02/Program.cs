using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.Exceptions;

namespace TP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje;

            Console.WriteLine("TP02");
            ExceptionsTP02.RealizarOperacion();
            ExceptionsTP02.RealizarExcepcion();
            Console.WriteLine("Ingrese el mensaje de la excepción custom");
            mensaje = Console.ReadLine();
            ExceptionsTP02.ExcepcionCustom(mensaje);
            Console.ReadLine();
        }
    }
}
