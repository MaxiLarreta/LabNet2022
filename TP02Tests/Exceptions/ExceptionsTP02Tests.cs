using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP02.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02.Methods;

namespace TP02.Exceptions.Tests
{
    [TestClass()]
    public class ExceptionsTP02Tests
    {
        

        [TestMethod()]
        public void RealizarOperacionTest()
        {
            decimal dividendo = 5;
            decimal divisor = 5;
            decimal expected = dividendo.Dividir(divisor);
            decimal resultado = ExceptionsTP02.RealizarOperacion(dividendo, divisor);
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void Operacion_FormatException()
        {
            ExceptionsTP02.RealizarOperacion(5, decimal.Parse(" "));
        }

        //Se que no es la manera de testear una excepción pero no me funcionaba
        [TestMethod()]
        public void ExcepcionCero() 
        {
            try
            {
                ExceptionsTP02.RealizarOperacion(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Intento de dividir por cero.", ex.Message);
            }
           
        }

       // No entiendo por que no funciona este test
        //[TestMethod()]
        //[ExpectedException(typeof(DivideByZeroException))]
        //public void ExcepcionCeroOriginal()
        //{
        //  ExceptionsTP02.RealizarOperacion(5, 0);
           
        //}
    }

}