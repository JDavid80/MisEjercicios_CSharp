using System;

class Program
{
    static void Main(string[] args)
    {
        Aprendiz apSena = new Aprendiz();
        apSena.Nombres = "Jesus David";
        apSena.Apellidos = "Calderón Gomez";
        Saludo(apSena);
    }
    private static void Saludo(Aprendiz ApSena)
    {
        Console.WriteLine("Bienvenido, sr(a) " 
            + ApSena.Nombres);
        Console.ReadLine();
    }
}


