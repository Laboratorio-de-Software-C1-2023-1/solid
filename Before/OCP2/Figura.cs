using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP2
{
    public class Figura
    {
        private string tipo;

        public Figura(string tipo)
        {
            this.tipo = tipo;
        }

        public double area()
        {
            if (tipo == "cuadrado")
            {
                // Devuelve cálculo área del cuadrado
                return 1;
            } else if (tipo == "rectangulo")
            {
                // Devuelve cálculo área del rectangulo
                return 2;
            } else
            {
                // Devuelve cálculo área del circulo
                return 3;
            }
        }
    }
}
