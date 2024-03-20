using System;

namespace OCP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura cuadrado = new Cuadrado();
            Console.WriteLine(cuadrado.area());

            Figura rectangulo = new Rectangulo();
            Console.WriteLine(rectangulo.area());

            Figura circulo = new Circulo();
            Console.WriteLine(circulo.area());

            Figura trianguloEquilatero = new TrianguloEquilatero();
            Console.WriteLine(trianguloEquilatero.area());
        }
    }
}
