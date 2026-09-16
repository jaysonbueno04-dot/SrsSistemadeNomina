using SrsSistemadeNomina.Models;
using SrsSistemadeNomina.Services;
using System;

namespace SrsSistemadeNomina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nomina = new GestionNominaService();

            var asalariado = new EmpleadoAsalariado("Juan", "Pérez", "111-222333-4", 800.00m);
            var porHoras = new EmpleadoPorHoras("María", "López", "222-333444-5", 16.75m, 42);
            var porComision = new EmpleadoPorComision("Carlos", "Gómez", "333-444555-6", 10000.00m, 0.06m);
            var baseMasComision = new EmpleadoBaseMasComision("Ana", "Martínez", "444-555666-7", 5000.00m, 0.04m, 300.00m);

            nomina.RegistrarEmpleado(asalariado);
            nomina.RegistrarEmpleado(porHoras);
            nomina.RegistrarEmpleado(porComision);
            nomina.RegistrarEmpleado(baseMasComision);

            Console.WriteLine(nomina.GenerarReporteSemanal());

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}