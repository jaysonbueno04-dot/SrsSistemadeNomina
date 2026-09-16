namespace SrsSistemadeNomina.Models
{
    public abstract class Empleado : IPagable
    {
        public string PrimerNombre { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string NumeroSeguroSocial { get; set; } = string.Empty;

        protected Empleado(string primerNombre, string apellidoPaterno, string nss)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = nss;
        }

        public abstract decimal CalcularIngresos();

        public override string ToString() => $"{PrimerNombre} {ApellidoPaterno} | NSS: {NumeroSeguroSocial}";
    }
}