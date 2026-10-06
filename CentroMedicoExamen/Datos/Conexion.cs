using Microsoft.Data.SqlClient;

namespace CentroMedicoExamen.Datos
{
    public class Conexion
    {
        private string cadenaConexion =
            "Server=localhost;Database=DB_CentroMedico_Examen;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}