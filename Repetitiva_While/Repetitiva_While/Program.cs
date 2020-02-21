using System;

class Program
{
    static void Main(string[] args)
    {
        string NombreUsuario = "";
        int NumeroUsuario = 1;
        Console.Write("Por favor, ingresa tu nombre: ");
        NombreUsuario = Console.ReadLine();

        //Estructura repetitiva para preguntar por el nombre
        while (NombreUsuario != "FIN")
        {
            Console.WriteLine("Usuario N. " + NumeroUsuario);
            Console.WriteLine("Bienvenido, sr(a)" + NombreUsuario);
            Console.WriteLine();
            Console.Write("Por favor, ingresa tu nombre: ");
            NombreUsuario = Console.ReadLine();
            NumeroUsuario += 1;
        }
        Console.WriteLine("Fin del Programa");
        Console.ReadLine();
    }
}

