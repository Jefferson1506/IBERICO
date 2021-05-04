using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IBERICO.Datos
{
    class Acciones
    {
        private int numero ;
        private int numero2;


        public string saludar1( string a)
        {
            return "HOLA  "+a+" PAPI RICO "; 
        }

        public int sumar(int a,int b)
        {
            return a + b;
        }

        public int resta(int a, int b)
        {
            return a - b;
        }

        public int multiplicar(int a, int b)
        {
            return a * b;
        }

        public double dividir(int a, int b)
        {
            return a / b;
        }
    }

  

}
