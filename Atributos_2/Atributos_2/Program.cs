using System;

class Program
{
    static void Main(string[] args)
    {
        Aprendiz apSena = new Aprendiz();
        Preguntas(apSena);
    }
    private static void Preguntas(Aprendiz apSena)
    {
        Console.WriteLine("===Registro de Aprendices===");
        Console.Write("Ingrese su tipo de identificación: ");
        apSena.TipoIdentificacion = Console.ReadLine();
        Console.Write("Ingrese su número de identificación: ");
        apSena.NumeroIdentificacion = Console.ReadLine();
        Console.Write("Ingrese su Nombre completo: ");
        apSena.Nombres = Console.ReadLine();
        Console.Write("Ingrese su Apellido: ");
        apSena.Apellidos = Console.ReadLine();
        Console.Write("Ingrese su Fecha de Nacimiento: ");
        apSena.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Ingrese su Genero: ");
        apSena.Genero = Console.ReadLine();
        Console.Write("Ingrese su ID Ficha: ");
        apSena.IDFicha = Console.ReadLine();
        Console.Write("Ingrese su Estado: ");
        apSena.Estado = Console.ReadLine();
        Console.Write("Ingrese su Estado Civil: ");
        apSena.EstadoCivil = Console.ReadLine();
        Console.Write("Ingrese su Dirección: ");
        apSena.Direccion = Console.ReadLine();
        Console.Write("Ingrese su Tipo de Sangre: ");
        apSena.RH = Console.ReadLine();
        Console.Write("Ingrese su Email: ");
        apSena.Email = Console.ReadLine();

        MostrarRespuestas(apSena);
    }
    private static void MostrarRespuestas(Aprendiz apSena)
    {
        Console.WriteLine("\n===Información===");
        Console.WriteLine("Tipo de Identificación.." + apSena.TipoIdentificacion);
        Console.WriteLine("Nombre.................." + apSena.Nombres);
        Console.WriteLine("Apellidos..............." + apSena.Apellidos);
        Console.WriteLine("Fecha de Nacimiento....." + apSena.FechaNacimiento.Day + "/" +
             apSena.FechaNacimiento.Month + "/" + apSena.FechaNacimiento.Year);
        Console.WriteLine("Genero.................." + apSena.Genero);
        Console.WriteLine("ID Ficha ..............." + apSena.IDFicha);
        Console.WriteLine("Estado.................." + apSena.Estado);
        Console.WriteLine("Estado Civil............" + apSena.EstadoCivil);
        Console.WriteLine("Dirección..............." + apSena.Direccion);
        Console.WriteLine("Tipo de Sangre.........." + apSena.RH);
        Console.WriteLine("Email..............." + apSena.Email);
        
        Console.ReadLine();
    }
}

