using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP2
{
    public class TrianguloEquilatero : Figura
    {

        public TrianguloEquilatero(string tipo) : base(tipo) { }

        public override double area()
        {
            // Devuelve cálculo área del triangulo equilatero
            return 4;
        }
    }
}
