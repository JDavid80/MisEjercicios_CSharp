using System;

class Program
{
    static void Main(string[] args)
    {
        string NombreUsuario = "";

        Console.Write("Por favor, ingresa tu nombre: ");
        NombreUsuario = Console.ReadLine();

        Console.WriteLine("Bienvenido(a), " + NombreUsuario + ".");
        Console.ReadLine();
    }
}

