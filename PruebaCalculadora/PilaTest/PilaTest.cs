using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaCalculadora;

namespace PilaTest
{
    [TestClass]
    public class PilaTest
    {
        
        
        
        [TestMethod]
        public void ponerTest()
        {
            Pila p = new Pila();    
            p.poner("Primera");
            p.poner("Segunda");
            p.poner("Tercera");
            Assert.AreEqual(3, p.size());

        }

        [TestMethod]
        public void sacarTest()
        {
            Pila p = new Pila();
            p.poner("Primera");
            p.poner("Segunda");
            p.poner("Tercera");
            string rta = p.sacar();
            Assert.AreEqual("Tercera", rta);
        }

  
    }
}
