using System.Text;
using SrsSistemadeNomina.Models;

namespace SrsSistemadeNomina.Services
{
    public class GestionNominaService
    {
        private readonly List<Empleado> _empleados = new();

        public void RegistrarEmpleado(Empleado empleado) => _empleados.Add(empleado);

        public IEnumerable<Empleado> ObtenerTodos() => _empleados;

        public string GenerarReporteSemanal()
        {
            var sb = new StringBuilder();
            sb.AppendLine("=== REPORTE SEMANAL DE NOMINA ===");
            sb.AppendLine();

            foreach (var emp in _empleados)
            {
                sb.AppendLine($"Tipo: {emp.GetType().Name}");
                sb.AppendLine($"Empleado: {emp}");
                sb.AppendLine($"Pago Semanal: ${emp.CalcularIngresos():N2}");
                sb.AppendLine(new string('-', 40));
            }

            return sb.ToString();
        }
    }
}