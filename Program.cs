using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=== 1 ===");
        Console.Write("Número: ");
        int num = int.Parse(Console.ReadLine());
        int res = sumar(num);
        Console.WriteLine("Resultado: " + res);
        Console.WriteLine();

        Console.WriteLine("=== 2 ===");
        int x = 6;
        Console.WriteLine("Antes: " + x);
        string msg = cuadrado(ref x);
        Console.WriteLine(msg);
        Console.WriteLine("Después: " + x);
        Console.WriteLine();

        Console.WriteLine("=== 3 ===");
        Console.Write("Precio: ");
        double p = double.Parse(Console.ReadLine());
        Console.Write("Desc (ej 0.2): ");
        double d = double.Parse(Console.ReadLine());

        double desc = descuento(d, ref p);
        Console.WriteLine("Final: " + p + " | Desc: " + desc);
        Console.WriteLine();

        Console.WriteLine("=== 4 ===");
        int e = 10;
        Console.WriteLine("Energía: " + e);

        Console.WriteLine("Consume: " + usar(ref e));
        Console.WriteLine("Recarga: " + cargar(ref e));
        Console.WriteLine("Estado: " + estado(e));
        Console.WriteLine("Rango: " + rango(e));
    }

    static int sumar(int n)
    {
        int s = 0;
        while (n > 0)
        {
            s += n % 10;
            n /= 10;
        }
        return s;
    }

    static string cuadrado(ref int n)
    {
        n *= n;
        return "Listo";
    }

    static double descuento(double d, ref double p)
    {
        double m = p * d;
        p -= m;
        return m;
    }

    static int usar(ref int e)
    {
        e -= 4;
        if (e < 0) e = 0;
        return e;
    }

    static int cargar(ref int e)
    {
        e += 6;
        if (e > 20) e = 20;
        return e;
    }

    static string estado(int e)
    {
        if (e >= 15) return "Alta";
        if (e >= 8) return "Media";
        return "Baja";
    }

    static string rango(int e)
    {
        if (e == 20) return "S";
        if (e >= 15) return "A";
        if (e >= 8) return "B";
        return "C";
    }
}