using System;

namespace OCP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura cuadrado = new Cuadrado("cuadrado");
            Console.WriteLine(cuadrado.area());

            Figura rectangulo = new Rectangulo("rectangulo");
            Console.WriteLine(rectangulo.area());

            Figura circulo = new Circulo("circulo");
            Console.WriteLine(circulo.area());

            Figura trianguloEquilatero = new TrianguloEquilatero("circulo");
            Console.WriteLine(trianguloEquilatero.area());
        }
    }
}
