//Autor: Jesus David Calderón
using System;

class Program
{
    static void Main(string[] args)
    {
        int edad = 0;
        string genero = "";
        int Dinero = 0;
        string Tarjeta = "";
        //Console.WriteLine("Por favor, ingrese la edad: ");
        //Int32.TryParse(Console.ReadLine(), out edad);
        //Console.WriteLine("Por favor, ingrese el genero: (H/M)");
        //genero = Console.ReadLine();

        if (edad > 18 && genero == "M")
        {
            Console.WriteLine("Bienvenidas");
        }
        else
        {
            Console.WriteLine("Lo sentimos, no cumples con los requisitos");
        }
        //Operador OR
        Console.WriteLine("Costo del Producto: $10.000");
        Console.WriteLine("Por favor, ingrese la cantidad de dinero: ");
        Int32.TryParse(Console.ReadLine(), out Dinero);
        Console.WriteLine("Cuentas con alguna tarjeta: (S/N)");
        Tarjeta = Console.ReadLine();
        if (Dinero >= 10000 || Tarjeta == "S")
        {
            Console.WriteLine("Felicitaciones. Tu compra ha sido exitosa");
        }
        else
        {
            Console.WriteLine("Lo sentimos. No cumple " +
                "con ninguno de los requisitos.");
        }
        Console.ReadLine();
    }
}

