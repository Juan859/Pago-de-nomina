using System;

namespace CalculadoraHorasTrabajadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Horas Trabajadas");

            Console.Write("Ingrese la hora de inicio (formato HH:mm): ");
            string horaInicioStr = Console.ReadLine();
            DateTime horaInicio = DateTime.ParseExact(horaInicioStr, "HH:mm", null);

            Console.Write("Ingrese la hora de finalización (formato HH:mm): ");
            string horaFinStr = Console.ReadLine();
            DateTime horaFin = DateTime.ParseExact(horaFinStr, "HH:mm", null);

            // Cálculo de las horas trabajadas
            TimeSpan horasTrabajadas = horaFin horaInicio;

            Console.WriteLine($"Horas trabajadas: {horasTrabajadas.TotalHours:F2}");

            Console.ReadLine();
        }
    }
}
