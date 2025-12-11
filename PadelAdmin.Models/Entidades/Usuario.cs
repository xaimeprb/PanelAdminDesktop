namespace PadelAdmin.Models.Entities
{
    /// <summary>
    /// Representa un usuario del sistema (Admin, SuperAdmin o Vecino).
    /// </summary>
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string PasswordHash { get; set; }
        public int IdRol { get; set; }
        public int IdUrbanizacion { get; set; }
        public string Portal { get; set; }
        public string Piso { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
