namespace PadelAdmin.Models.Entities
{
    /// <summary>
    /// Representa una incidencia asociada a una pista.
    /// </summary>
    public class Incidencia
    {
        public int IdIncidencia { get; set; }
        public int IdUrbanizacion { get; set; }
        public int IdPista { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
