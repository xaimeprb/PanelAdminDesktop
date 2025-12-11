using System.Data.SqlClient;
using PadelAdmin.Models.Entities;

namespace PadelAdmin.DAL.Repositories
{
    public class UsuarioRepositorio
    {
        public UsuarioRepositorio() { }

        public Usuario ObtenerPorEmail(string email)
        {
            using (SqlConnection conn = Database.Instance.GetConnection())
            {
                string sql = @"
                    SELECT IdUsuario, Nombre, Apellidos, Email, Telefono,
                           PasswordHash, IdRol, IdUrbanizacion, Portal, Piso,
                           Activo, FechaRegistro
                    FROM Usuarios
                    WHERE Email = @Email AND Activo = 1";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {

                            return null;

                        }

                        int idUsuario = dr.GetInt32(0);
                        string nombre = dr.GetString(1);
                        string apellidos = dr.GetString(2);
                        string emailDb = dr.GetString(3);

                        string telefono = null;

                        if (!dr.IsDBNull(4))
                        {

                            telefono = dr.GetString(4);

                        }

                        string passwordHash = dr.GetString(5);
                        int idRol = dr.GetInt32(6);
                        int idUrbanizacion = dr.GetInt32(7);

                        string portal = null;

                        if (!dr.IsDBNull(8))
                        {

                            portal = dr.GetString(8);

                        }

                        string piso = null;

                        if (!dr.IsDBNull(9))
                        {

                            piso = dr.GetString(9);

                        }

                        bool activo = dr.GetBoolean(10);
                        DateTime fechaRegistro = dr.GetDateTime(11);

                        Usuario u = new Usuario(idUsuario, nombre, apellidos, emailDb, telefono, passwordHash, idRol, idUrbanizacion, portal, piso, activo, fechaRegistro);

                        return u;

                    }
                }
            }
        }
    }
}
