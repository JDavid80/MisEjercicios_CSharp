using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Aprendices = new string[3];

            for (int apr=0; apr<= 2; apr++)
            {
                Console.Write("Por favor, Ingrese el aprendiz n° " + (apr + 1) + ": ");
                Aprendices[apr] = Console.ReadLine();
            }
            for (int apr = 0; apr <= 2; apr++)
            {
                Console.WriteLine((apr + 1) + ". " + Aprendices[apr]);
            }
            Console.WriteLine("Fin de la aplicación");
            Console.ReadLine();
        }
    }
}
