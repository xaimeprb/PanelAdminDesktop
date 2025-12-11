namespace PadelAdmin.Models.Entities
{
    /// <summary>
    /// Representa una reserva de una pista por parte de un usuario.
    /// </summary>
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdUrbanizacion { get; set; }
        public int IdUsuario { get; set; }
        public int IdPista { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public int Duracion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
