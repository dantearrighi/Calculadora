using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaCalculadora;

namespace TestCalculadora
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        //METODO SUMARTEST
        void sumarTest()
        {
            Calculadora c = new Calculadora();
            int result = c.sumar(2, 2);
            Assert.AreEqual(4, result);

        }
    }
}
