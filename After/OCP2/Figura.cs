using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP2
{
    public abstract class Figura
    {
        private string tipo;

        public Figura(string tipo)
        {
            this.tipo = tipo;
        }

        public abstract double area();
    }
}
