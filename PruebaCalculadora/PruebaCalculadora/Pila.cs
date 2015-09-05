using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCalculadora
{
    public class Pila
    {
       public  void poner(string cadena)
        {
            pila.Push(cadena);

        }

        Stack<string> pila = new Stack<string>();

        public string sacar()
        {
            return pila.ElementAt(size());
        }


      public   int size()
        {
            return pila.Count();
        }
    }
}
