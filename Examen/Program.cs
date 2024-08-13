using Examen;
using System;

class Program
{
    static void Main()
    {
        Asignatura asignatura = new Asignatura();

        
        Console.Write("Ingrese el nombre del alumno: ");
        asignatura.NombreAlumno = Console.ReadLine();

        Console.Write("Ingrese el número de cuenta del alumno: ");
        asignatura.NumeroCuenta = Console.ReadLine();

        Console.Write("Ingrese el email del alumno: ");
        asignatura.Email = Console.ReadLine();

       
        Console.Write("Ingrese el nombre de la asignatura: ");
        asignatura.NombreAsignatura = Console.ReadLine();

        Console.Write("Ingrese el horario de la asignatura: ");
        asignatura.Horario = Console.ReadLine();

        Console.Write("Ingrese el nombre del docente: ");
        asignatura.NombreDocente = Console.ReadLine();

        
        while (true)
        {
            try
            {
                Console.Write("Ingrese la nota del primer parcial (0-30): ");
                asignatura.N1 = int.Parse(Console.ReadLine());
                if (asignatura.N1 < 0 || asignatura.N1 > 30) throw new Exception();

                Console.Write("Ingrese la nota del segundo parcial (0-30): ");
                asignatura.N2 = int.Parse(Console.ReadLine());
                if (asignatura.N2 < 0 || asignatura.N2 > 30) throw new Exception();

                Console.Write("Ingrese la nota del tercer parcial (0-40): ");
                asignatura.N3 = int.Parse(Console.ReadLine());
                if (asignatura.N3 < 0 || asignatura.N3 > 40) throw new Exception();

                break;
            }
            catch
            {
                Console.WriteLine("Entrada inválida. Asegúrese de ingresar un número entero dentro del rango permitido.");
            }
        }

       
        asignatura.Imprimir();
    }
}

