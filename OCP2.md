# SOLID

# Open Close Principle

Supongamos que tenemos una clase llamada `Figura` que es responsable de calcular el área de distintos tipos de figuras geométricas.

```csharp
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
```

Pasado el tiempo, nos indican que en el sistema se deberá calcular el área de un triangulo equilátero.

Es aquí donde notamos que debemos alterar la clase ya existente `Figura` y si, en esta manipulación, intriducimos un bug en la misma el mismo no solo puede afectar al triángulo sino a las figuras geométricas existentes. Es por ello que se decide hacer un refactor completo del código siguiendo las buenas prácticas SOLID:

```csharp
public abstract class Figura
{
    private string tipo;

    public Figura(string tipo)
    {
        this.tipo = tipo;
    }

    public abstract double area();
}

public class Cuadrado : Figura
{

    public Cuadrado(string tipo) : base(tipo) { }

    public override double area()
    {
        // Devuelve cálculo área del cuadrado
        return 1;
    }
}

public class Rectangulo : Figura
{

    public Rectangulo(string tipo) : base(tipo) { }

    public override double area()
    {
        // Devuelve cálculo área del rectangulo
        return 2;
    }
}

public class Circulo : Figura
{
    public Circulo(string tipo) : base(tipo) { }

    public override double area()
    {
        // Devuelve cálculo área del circulo
        return 3;
    }
}

public class TrianguloEquilatero : Figura
{

    public TrianguloEquilatero(string tipo) : base(tipo) { }

    public override double area()
    {
        // Devuelve cálculo área del triangulo equilatero
        return 4;
    }
}
```

De esta forma, si aparecen nuevos tipos de figuras geométricas, se creará una clase específica para ello sin tener que alterar el comportamiento del resto de las clases.
