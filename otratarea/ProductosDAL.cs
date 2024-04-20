using System;
using System.Data;
using System.Data.SqlClient;

namespace otratarea
{
    public class ProductosDAL
    {
        private string connectionString; // Aquí deberías tener tu cadena de conexión a la base de datos

        public ProductosDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable ObtenerProductos()
        {
            DataTable productos = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Productos";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(productos);
            }

            return productos;
        }
    }
}
