using System;
using System.Data;
using System.Data.SqlClient;

public class Productosa
{
    private readonly string connectionString; // Cadena de conexión a la base de datos

      public Productosa(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Insertar un nuevo producto
    public void InsertarProducto(string nombre, decimal precio, string Categoria)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Productos ( Nombre, Precio, Categoria) VALUES ( @Nombre, @Precio, @Categoria)", connection);

            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Precio", precio);
            command.Parameters.AddWithValue("@Categoria", Categoria);
            command.ExecuteNonQuery();
        }
    }

    // Eliminar un producto por su ID
    public void EliminarProducto(int id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Productos WHERE ID = @ID", connection);
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
        }
    }

    // Actualizar información de un producto
    public void ActualizarProducto(int Id, string nombre, decimal precio, string Categoria)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria  WHERE ID = @ID", connection);

            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Precio", precio);
            command.Parameters.AddWithValue("@Categoria", Categoria);
            command.Parameters.AddWithValue("@ID", Id);
            command.ExecuteNonQuery();
        }
    }

    // Obtener todos los productos
    public DataTable ObtenerProductos()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Productos", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;

        }
    }
    public DataTable BuscarProductos(string criterio)
    {
        DataTable dataTable = new DataTable();

        // Crear la consulta SQL para buscar productos que coincidan con el criterio
        string consulta = "SELECT * FROM Productos WHERE Nombre LIKE @Criterio OR Categoria LIKE @Criterio";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(consulta, connection))
            {
                // Agregar el parámetro de criterio con comodines de búsqueda
                command.Parameters.AddWithValue("@Criterio", "%" + criterio + "%");

                // Abrir la conexión y ejecutar la consulta
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
        }

        return dataTable;
    }

}
