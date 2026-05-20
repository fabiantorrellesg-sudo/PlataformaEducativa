using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PlataformaEducativa.Clases
{
    internal class ConexionBD
    {
        private static string cadenaConexion = "Server=localhost; Database=peducativa; Uid=root; Pwd=;";

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            try
            {
                conectar.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos, error: " + e.Message);
            }
            return conectar;
        }

        public static void cerrarConexion(MySqlConnection conexionActiva)
        {
            if (conexionActiva != null && conexionActiva.State == ConnectionState.Open)
            {
                conexionActiva.Close();
                conexionActiva.Dispose(); // Libera por completo los recursos
            }
        }
    }
}
