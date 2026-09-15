namespace SrsSistemadeNomina
{
    public class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        public decimal SalarioBase { get; set; }

        public EmpleadoBaseMasComision(string nombre, string apellido, string nss, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase)
            : base(nombre, apellido, nss, ventasBrutas, tarifaComision)
        {
            SalarioBase = salarioBase;
        }

        public override decimal CalcularIngresos()
        {
            decimal salarioConBonificacion = SalarioBase + (SalarioBase * 0.10m);
            return base.CalcularIngresos() + salarioConBonificacion;
        }
    }
}