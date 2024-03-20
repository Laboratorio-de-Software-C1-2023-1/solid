using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP2
{
    public class Rectangulo : Figura
    {

        public Rectangulo(string tipo) : base(tipo) { }

        public override double area()
        {
            // Devuelve cálculo área del rectangulo
            return 2;
        }
    }
}
