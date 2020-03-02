using System;

class Program
{
    static void Main(string[] args)
    {
        Aprendiz apSena = new Aprendiz();
        AsignarNombre(apSena);
    }
    private static void AsignarNombre(Aprendiz aprendiz)
    {
        aprendiz.Nombres = "Jesus David";
        aprendiz.Apellidos = "Calderón Gomez";
        Saludo(aprendiz);
    }
    private static void Saludo(Aprendiz ApSena)
    {
        Console.WriteLine("Bienvenido, sr(a) " 
            + ApSena.Nombres);
        Console.ReadLine();
    }
}


