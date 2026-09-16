namespace SrsSistemadeNomina.Models
{
    public class EmpleadoPorHoras : Empleado
    {
        public decimal SueldoPorHora { get; set; }
        public decimal HorasTrabajadas { get; set; }

        public EmpleadoPorHoras(string nombre, string apellido, string nss, decimal sueldoPorHora, decimal horasTrabajadas)
            : base(nombre, apellido, nss)
        {
            SueldoPorHora = sueldoPorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularIngresos()
        {
            if (HorasTrabajadas <= 40)
                return SueldoPorHora * HorasTrabajadas;

            return SueldoPorHora * 40 + SueldoPorHora * 1.5m * (HorasTrabajadas - 40);
        }
    }
}