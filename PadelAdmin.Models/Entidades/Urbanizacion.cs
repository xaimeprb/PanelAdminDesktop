namespace PadelAdmin.Models.Entities
{
    /// <summary>
    /// Representa una urbanización (tenant) dentro del sistema.
    /// </summary>
    public class Urbanizacion
    {
        public int IdUrbanizacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public bool Activa { get; set; }
    }
}
