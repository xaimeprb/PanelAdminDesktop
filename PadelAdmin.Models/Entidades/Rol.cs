namespace PadelAdmin.Models.Entities
{
    /// <summary>
    /// Define los roles del sistema (SuperAdmin, Admin, Vecino).
    /// </summary>
    public class Rol
    {
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
