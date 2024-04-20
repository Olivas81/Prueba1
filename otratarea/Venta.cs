using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otratarea
{
    public partial class Venta : Form
    {
        string connectionString =  "Server=Wilson;Database=Super;Integrated Security=true;";
        private ProductosDAL productosDAL;
        private List<Producto> productosSeleccionados;

        public Venta(string connectionString)
        {
            InitializeComponent();
            productosDAL = new ProductosDAL(connectionString);
            productosSeleccionados = new List<Producto>();
            CargarProductos();
        }


        private void CargarProductos()
        {
            try
            {
                DataTable productos = productosDAL.ObtenerProductos();
                dataGridView1.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verificar si el clic se realizó en una celda válida y no en el encabezado de la columna
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Crear un objeto Producto con los datos de la fila seleccionada
                Producto producto = new Producto
                {
                    Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                    Nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value),
                    Precio = Convert.ToDecimal(selectedRow.Cells["Precio"].Value),
                    Categoria = Convert.ToString(selectedRow.Cells["Categoria"].Value)
                };

                // Agregar el producto seleccionado a la lista de productos seleccionados
                productosSeleccionados.Add(producto);

                // Actualizar la visualización de los productos seleccionados en otro control, como un ListBox o DataGridView
                ActualizarProductosSeleccionados();
            }
        }
        private void ActualizarProductosSeleccionados()
        {
            // Aquí puedes actualizar la visualización de los productos seleccionados en otro control, como un ListBox o DataGridView
            // Por ejemplo:
            listBoxProductosSeleccionados.Items.Clear();
            foreach (var producto in productosSeleccionados)
            {
                listBoxProductosSeleccionados.Items.Add(producto.Nombre);
            }
        }

        private void listBoxProductosSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            
                try
                {
                    // Calcular el total de la venta
                    decimal totalVenta = CalcularTotalVenta();

                    // Registrar la venta en la base de datos
                    RegistrarVenta(totalVenta);

                    // Actualizar la interfaz de usuario
                    LimpiarProductosSeleccionados();
                    MessageBox.Show("Venta realizada exitosamente.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            


        }
        private decimal CalcularTotalVenta()
        {
            decimal totalVenta = 0;

            // Sumar el precio de cada producto seleccionado
            foreach (var producto in productosSeleccionados)
            {
                totalVenta += producto.Precio;
            }

            return totalVenta;
        }

        private void RegistrarVenta(decimal totalVenta)
        {
            // Obtener la fecha y hora actual
            DateTime fechaVenta = DateTime.Now;

            // Insertar la venta en la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Venta (FechaVenta, TotalVenta) VALUES (@FechaVenta, @TotalVenta)", connection);
                command.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                command.Parameters.AddWithValue("@TotalVenta", totalVenta);
                command.ExecuteNonQuery();
            }

            // Registrar los productos vendidos en la tabla de detalles de venta
            foreach (var producto in productosSeleccionados)
            {
                RegistrarDetalleVenta(producto.Id, fechaVenta);
            }
        }

        private void RegistrarDetalleVenta(int idProducto, DateTime fechaVenta)
        {
            // Insertar el detalle de la venta en la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO DetalleVenta (IdVenta, IdProducto) VALUES ((SELECT MAX(IdVenta) FROM Venta), @IdProducto)", connection);
                command.Parameters.AddWithValue("@IdProducto", idProducto);
                command.ExecuteNonQuery();
            }
        }
        private void LimpiarProductosSeleccionados()
        {
            productosSeleccionados.Clear();
            ActualizarProductosSeleccionados();
        }

    }
}
