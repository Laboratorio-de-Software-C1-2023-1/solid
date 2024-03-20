using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP2
{
    public class Circulo : Figura
    {

        public Circulo(string tipo) : base(tipo) { }

        public override double area()
        {
            // Devuelve cálculo área del circulo
            return 3;
        }
    }
}
