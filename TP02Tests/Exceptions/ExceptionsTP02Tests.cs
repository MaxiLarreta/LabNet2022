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
            decimal? expected = dividendo.Dividir(divisor);
            decimal? resultado = ExceptionsTP02.RealizarOperacion(dividendo, divisor);
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod()]
        public void ExcepcionCero()
        {
            decimal dividendo = 5;
            decimal divisor = 0;
            decimal? resultado = dividendo.Dividir(divisor);
            Assert.IsNull(resultado);
        }

        [TestMethod()]
        public void RealizarOperacionConCero()
        {
            decimal dividendo = 5;
            decimal divisor = 0;
            decimal? resultado = ExceptionsTP02.RealizarOperacion(dividendo, divisor);
            Assert.IsNull(resultado);
        }
    }

}