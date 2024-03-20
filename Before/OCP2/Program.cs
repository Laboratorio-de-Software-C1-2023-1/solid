using System;

namespace OCP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura cuadrado = new Figura("cuadrado");
            Console.WriteLine(cuadrado.area());

            Figura rectangulo = new Figura("rectangulo");
            Console.WriteLine(rectangulo.area());

            Figura circulo = new Figura("circulo");
            Console.WriteLine(circulo.area());
        }
    }
}
