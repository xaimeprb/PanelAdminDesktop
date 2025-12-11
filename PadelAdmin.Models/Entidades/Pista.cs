namespace PadelAdmin.Models.Entities
{
    /// <summary>
    /// Representa una pista de la urbanización.
    /// </summary>
    public class Pista
    {
        public int IdPista { get; set; }
        public int IdUrbanizacion { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int DuracionTurno { get; set; }
        public bool Activa { get; set; }
    }
}
