using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public static class AccesoDatos
    {
        private static string connectionString = "Server=DESKTOP-DOOUSUP;Database=SegundoParcial;Trusted_Connection=True;";

        public static void CrearTablaSiNoExiste()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Reparaciones' and xtype='U')
                CREATE TABLE Reparaciones (
                    id INT PRIMARY KEY IDENTITY(1,1),
                    mensaje VARCHAR(255) NOT NULL,
                    alumno VARCHAR(255) NOT NULL
                )";
                using (var command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void GuardarReparacion(string mensaje, string alumno)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Reparaciones (mensaje, alumno) VALUES (@mensaje, @alumno)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mensaje", mensaje);
                    command.Parameters.AddWithValue("@alumno", alumno);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static List<string> LeerReparaciones()
        {
            List<string> reparaciones = new List<string>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Reparaciones";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string mensaje = reader["mensaje"].ToString();
                            string alumno = reader["alumno"].ToString();
                            reparaciones.Add($"{mensaje}");
                        }
                    }
                }
            }

            return reparaciones;
        }

        public static void ActualizarMensajeReparacion(string mensajeActual, string nuevoMensaje)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Reparaciones SET mensaje = @nuevoMensaje WHERE mensaje = @mensajeActual";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nuevoMensaje", nuevoMensaje);
                    command.Parameters.AddWithValue("@mensajeActual", mensajeActual);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void EliminarReparacion(string mensaje)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Reparaciones WHERE mensaje = @mensaje";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mensaje", mensaje);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
