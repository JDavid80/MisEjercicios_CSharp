using System;

class Program
{
    static void Main(string[] args)
    {
        Calculadora();
    }
    public static void Calculadora()
    {
        int Operacion = 0;
        Console.WriteLine("Ingrese la operación: ");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Int32.TryParse(Console.ReadLine(), out Operacion);
        switch (Operacion)
        {
            case 1:
                Suma();
                break;
            //Completar el resto de la función...
        }
        FinEjercicio();
    }
    public static void Suma()
    {
        int Resultado = 0;
        int Num1 = 0;
        int Num2 = 0;
        Console.WriteLine("Ingrese el número 1: ");
        Int32.TryParse(Console.ReadLine(), out Num1);
        Console.WriteLine("Ingrese el número 2: ");
        Int32.TryParse(Console.ReadLine(), out Num2);
        Resultado = Num1 + Num2;
        Console.WriteLine("El resultado es: " + Resultado);
        Console.ReadLine();
    }
    public static void FinEjercicio()
    {
        string Respuesta = "";
        Console.Write("Desea realizar una nueva operación: (Y/N)");
        Respuesta = Console.ReadLine();
        if (Respuesta == "Y")
        {
            Calculadora();
        }
        else
        {
            Console.WriteLine("Fin del Ejercicio");
            Console.ReadLine();
        }
    }
}

