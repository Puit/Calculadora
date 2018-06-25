using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    public class Calculadora : ICalculadora, ICloneable // Implementamos los frameworks ICalculadora i ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int Division(int num1, int num2) // Creamos sus acciones, que hemos declarado en ICalculadora
        {
            return num1 / num2;
        }

        public int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
