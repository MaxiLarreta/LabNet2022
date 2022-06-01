using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.Methods;

namespace TP02.Exceptions
{
    public class ExceptionsTP02
    {

        public static decimal? RealizarOperacion(decimal? dividendo = null, decimal? divisor = null)
        {
            decimal numero1;
            decimal numero2;
            decimal? resultado = null;

            try
            {
                if (dividendo != null && divisor != null)
                {
                    resultado = dividendo.Value.Dividir(divisor.Value);
                }
                else
                {
                    Console.WriteLine("Ingrese el dividendo");
                    numero1 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el divisor");
                    numero2 = decimal.Parse(Console.ReadLine());
                    resultado = numero1.Dividir(numero2);
                }
                Console.WriteLine($"El resultado es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("La operacion de la división ha Finalizado");
            }
            return resultado;
        }

        public static void RealizarExcepcion()
        {
            try
            {
                Console.WriteLine("Inicio excepción forzada");
                int[] numero = null;
                numero.Count();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("La excepción forzada terminó");
            }
        }

        public static void ExcepcionCustom(string mensaje)
        {
            try
            { 
               throw new CustomException(mensaje);
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Se capturó la custom exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalizo custom exception");
            }
        }
    }
}
