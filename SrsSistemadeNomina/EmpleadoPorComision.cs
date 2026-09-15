namespace SrsSistemadeNomina
{
    public class EmpleadoPorComision : Empleado
    {
        public decimal VentasBrutas { get; set; }
        public decimal TarifaComision { get; set; }

        public EmpleadoPorComision(string nombre, string apellido, string nss, decimal ventasBrutas, decimal tarifaComision)
            : base(nombre, apellido, nss)
        {
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
        }

        public override decimal CalcularIngresos() => VentasBrutas * TarifaComision;
    }
}