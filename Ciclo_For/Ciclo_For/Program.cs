using System;

class Program
{
    static void Main(string[] args)
    {
        int Num = 0;
        Console.WriteLine("**Aumento**");
        for (int NumAp = 1; NumAp <= 11; NumAp++)
        {
            Console.WriteLine(NumAp);
        }
        Console.WriteLine("**Decremento**");
        for (int NumAp = 11; NumAp >= 1; NumAp--)
        {
            Console.WriteLine(NumAp);
        }
        //De 2 en 2
        for (Num = 1; Num <= 20; Num++)
        {
            Console.WriteLine(Num);
            Num++;
        }
        Console.WriteLine("Fin del Ejercicio");
        Console.ReadLine();
    }
}

