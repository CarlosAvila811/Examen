
namespace Examen
{
    public class Asignatura:Alumno,IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        

        public double CalcularNotaFinal()
        {
            return CalcularNotaFinal(N1, N2, N3);
        }

        public double CalcularNotaFinal(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal >= 0 && notaFinal <= 59)
                return "Reprobado";
            if (notaFinal >= 60 && notaFinal <= 79)
                return "Bueno";
            if (notaFinal >= 80 && notaFinal <= 89)
                return "Muy Bueno";
            if (notaFinal >= 90 && notaFinal <= 100)
                return "Sobresaliente";
            return "Nota fuera de rango";
        }

        public void Imprimir()
        {
            double notaFinal = CalcularNotaFinal();
            Console.WriteLine("\n--- Datos del Alumno ---");
            Console.WriteLine("Nombre: " + NombreAlumno);
            Console.WriteLine("Número de Cuenta: " + NumeroCuenta);
            Console.WriteLine("Email: " + Email);

           
            Console.WriteLine("Asignatura: " + NombreAsignatura);
            Console.WriteLine("Horario: " + Horario);
            Console.WriteLine("Nombre del Docente: " + NombreDocente);


            Console.WriteLine("\nNota Final :" + notaFinal.ToString() + "%" + " - " + MensajeNotaFinal(notaFinal));
            Console.WriteLine("Nota Final : " + CalcularNotaFinal(N1, N2, N3).ToString()+"%" + " - " + MensajeNotaFinal(CalcularNotaFinal(N1, N2, N3)));
        }
    }
}
