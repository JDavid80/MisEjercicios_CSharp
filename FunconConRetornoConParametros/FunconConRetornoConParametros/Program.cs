using System;

class Program
{
    static void Main(string[] args)
    {
        int NumeroNotas = 0;
        Console.WriteLine("===NOTAS===");
        Console.WriteLine("Ingrese el número de notas: ");
        Int32.TryParse(Console.ReadLine(), out NumeroNotas);
        string Resultado = CalcularNotas(NumeroNotas);
    }
    public static string CalcularNotas(int NumeroNotas)
    {
        decimal Nota = 0;
        decimal SumaNotas = 0;
        for (int i = 1; i <= NumeroNotas; i++)
        {
            Console.Write("Ingrese la nota N. " + i);
            decimal.TryParse(Console.ReadLine(), out Nota);
            //...
        }
        //Calcular la nota definitiva y devolver el mensaje
        //si aprobó o no aprobó
        return "";
    }
}

