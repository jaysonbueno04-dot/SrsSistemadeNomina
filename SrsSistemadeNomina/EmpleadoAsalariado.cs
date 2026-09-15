namespace SrsSistemadeNomina
{
    public class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal { get; set; }

        public EmpleadoAsalariado(string nombre, string apellido, string nss, decimal salarioSemanal)
            : base(nombre, apellido, nss)
        {
            SalarioSemanal = salarioSemanal;
        }

        public override decimal CalcularIngresos() => SalarioSemanal;
    }
}