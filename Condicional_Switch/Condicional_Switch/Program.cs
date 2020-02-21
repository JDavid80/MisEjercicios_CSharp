using System;

class Program
{
    static void Main(string[] args)
    {
        int dia = 0;
        int mes = 0;
        string mesLetras = "";
        int anyo = 0;

        Console.Write("Por favor, ingrese el día de nacimiento: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Por favor, ingrese el mes de nacimiento: ");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Por favor, ingrese el año de nacimiento: ");
        anyo = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1:
                mesLetras = "Enero";
                break;
            case 2:
                mesLetras = "Febrero";
                break;
            case 3:
                mesLetras = "Marzo";
                break;
            case 4:
                mesLetras = "Abril";
                break;
            case 5:
                mesLetras = "Mayo";
                break;
            case 6:
                mesLetras = "Junio";
                break;
            case 7:
                mesLetras = "Julio";
                break;
            case 8:
                mesLetras = "Agosto";
                break;
            case 9:
                mesLetras = "Septiembre";
                break;
            case 10:
                mesLetras = "Octubre";
                break;
            case 11:
                mesLetras = "Noviembre";
                break;
            case 12:
                mesLetras = "Diciembre";
                break;
            default:
                mesLetras = "Error";
                break;
        }
        if (mesLetras == "Error")
        {
            Console.WriteLine("La fecha ingresada es incorrecta.");
        }
        else
        {
            Console.WriteLine("Usted nació el " + 
                dia + " de " + mesLetras + " del año " + anyo);
        }
        Console.WriteLine("Fin del Ejercicio.");
        Console.ReadLine();
    }
}

