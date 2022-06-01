using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02.Methods
{
    public static class Operaciones
    {
        public static decimal? Dividir(this decimal dividendo, decimal divisor)
        {
            try
            {
               return dividendo / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Solo Chuck Norris divide por cero! Mensaje de excepción: {ex.Message}");
            }
            return null;
        }
    }
}
