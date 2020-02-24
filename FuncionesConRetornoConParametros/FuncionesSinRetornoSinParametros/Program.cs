using System;

public class Program
{
    public static void Main(string[] args)
    {
        Facturacion();
    }
    public static void Facturacion()
    {
        string RespUsuario = "";
        int codigoProducto = 0;
        int[] productos = new int[5];
        productos[1] = 2000;
        productos[2] = 500;
        productos[3] = 700;
        productos[4] = 200;
        Console.WriteLine("===Tienda Chucho===");
        Console.Write("Desea ingresar algun producto (Y/N)");
        RespUsuario = Console.ReadLine();
        while (RespUsuario == "Y")
        {
            Console.Write("Ingrese el código: ");
            Int32.TryParse(Console.ReadLine(), out codigoProducto);
            switch (codigoProducto)
            {
                case 0:
                    Console.WriteLine("Error");
                    break;

            }

        }
        MostrarResultado();
    }
    public static void MostrarResultado()
    {
    }
}

