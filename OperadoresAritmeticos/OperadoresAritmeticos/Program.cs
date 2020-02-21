using System;

class Program
{
    static void Main(string[] args)
    {
        string[] Operaciones = new string[5];
        Operaciones[0] = "Suma";
        Operaciones[1] = "Resta";
        Operaciones[2] = "Multiplicación";
        Operaciones[3] = "División";
        Operaciones[4] = "Error";
        int OpUsuario = 0;
        int Resultado = 0;
        int Num1 = 0;
        int Num2 = 0;
        string RespuestaUsuario = "";
        Console.WriteLine("Desea realizar algun tipo de operación: (Y/N)");
        RespuestaUsuario = Console.ReadLine();
        while (RespuestaUsuario == "Y")
        {
            Console.Write("Ingrese el primer entero: ");
            Int32.TryParse(Console.ReadLine(), out Num1);
            Console.WriteLine("Numero Ingresado: " + Num1);
            Console.ReadLine();
            //Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo entero: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            for (int op = 0; op <= 3; op++)
            {
                Console.WriteLine((op + 1) + ". " + Operaciones[op]);
            }
            Console.WriteLine("Seleccione una Operación: ");
            OpUsuario = Convert.ToInt32(Console.ReadLine());
             switch (OpUsuario)
            {
                case 1:
                    Console.WriteLine("Usted ha selecionado una Suma");
                    Resultado = Num1 + Num2;
                    break;
                case 2:
                    Console.WriteLine("Usted ha selecionado una Resta");
                    Resultado = Num1 - Num2;
                    break;
                case 3:
                    Console.WriteLine("Usted ha selecionado una Multiplicación");
                    Resultado = Num1 * Num2;
                    break;
                case 4:
                    Console.WriteLine("Usted ha selecionado una División");
                    Resultado = Num1 / Num2;
                    break;
                default:
                    Console.WriteLine("No seleccionó una operación válida.");
                    break;
            }
            Console.WriteLine("El resultado de la operación es: " + Resultado);
            Console.WriteLine("Desea realizar otra operación: (Y/N)");
            RespuestaUsuario = Console.ReadLine();
        }
        Console.WriteLine("Fin del Ejercicio");
        Console.ReadLine();
    }
}

