using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP2
{
    public class Cuadrado : Figura
    {

        public Cuadrado(string tipo) : base(tipo) { }

        public override double area()
        {
            // Devuelve cálculo área del cuadrado
            return 1;
        }
    }
}
