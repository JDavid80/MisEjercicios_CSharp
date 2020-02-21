using System;

class Program
{
    static void Main(string[] args)
    {
        string respuestaUsuario = "";
        int valorProducto = 0;
        int cantidadProducto = 0;
        int totalCompra = 0;
        int totalProducto = 0;

        Console.WriteLine("Desea agregar productos al carrito? ( Y / N ):");
        respuestaUsuario = Console.ReadLine();

        while (respuestaUsuario == "Y")
        {
            Console.WriteLine("Por favor, ingrese el valor del producto: ");
            valorProducto = Convert.ToInt32(Console.ReadLine());
            //2000

            Console.WriteLine("Por favor, ingrese el número de unidades del producto: ");
            cantidadProducto = Convert.ToInt32(Console.ReadLine());
            //3

            totalProducto = valorProducto * cantidadProducto;
            totalCompra += totalProducto;

            Console.WriteLine("Desea agregar mas productos al carrito? ( Y / N ):");
            respuestaUsuario = Console.ReadLine();
        }
        Console.WriteLine("Valor Total de la compra: " + totalCompra);
        Console.WriteLine("Fin de la aplicación");
        Console.ReadLine();
    }
}

