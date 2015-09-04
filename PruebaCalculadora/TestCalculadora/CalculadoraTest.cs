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
        [TestMethod]
       public void sumarTest()
        {
            Calculadora c = new Calculadora();
            int result = c.sumar(2, 2);
            Assert.AreEqual(4, result);

        }
        //METODO DIVIDIR TEST
        [TestMethod]
      public  void dividirTest()
        {
            Calculadora c = new Calculadora();
            double result = c.dividir(2, 2);
            Assert.AreEqual(1, result);
 
        }
        //METODO DIVIDIR POR CERO TEST
         [TestMethod]
        public void dividirPorCeroTest()
        {
            Calculadora c = new Calculadora();
            try
            {
                double result = c.dividir(2, 0);
                Assert.Fail("No deberia pasar por aca. Error en la division");
            }
            catch (Exception e)
            {
               
            }
        }

       
    }
}
