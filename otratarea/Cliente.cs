using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otratarea
{
    public partial class Cliente : Form
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=Wilson;Database=Super;Integrated Security=true;";

        public Cliente()
        {
            InitializeComponent();
            CargarClientes();   
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            // Validar que los campos no estén vacíos
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(telefono))
            {
                // Llamar al método para agregar cliente
                AgregarCliente(nombre, direccion, telefono);
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            // Validar que se haya seleccionado un cliente
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(telefono))
            {
                // Obtener el ID del cliente seleccionado
                int id = ObtenerIDSeleccionado();

                if (id > 0)
                {
                    // Llamar al método para actualizar cliente
                    ActualizarCliente(id, nombre, direccion, telefono);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del cliente seleccionado
            int id = ObtenerIDSeleccionado();

            if (id > 0)
            {
                // Llamar al método para eliminar cliente
                EliminarCliente(id);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarClientes();
        }

        private int ObtenerIDSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            }
            else
            {
                return 0;
            }
        }

        private void AgregarCliente(string nombre, string direccion, string telefono)
        {
            // Crear conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir conexión
                connection.Open();

                // Definir consulta SQL para insertar cliente
                string query = "INSERT INTO Cliente (Nombre, Direccion, Telefono) VALUES (@Nombre, @Direccion, @Telefono)";

                // Crear comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@Telefono", telefono);

                    // Ejecutar consulta
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ActualizarCliente(int id, string nombre, string direccion, string telefono)
        {
            // Crear conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir conexión
                connection.Open();

                // Definir consulta SQL para actualizar cliente
                string query = "UPDATE Cliente SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono WHERE ID = @ID";

                // Crear comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@Telefono", telefono);

                    // Ejecutar consulta
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void EliminarCliente(int id)
        {
            // Crear conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir conexión
                connection.Open();

                // Definir consulta SQL para eliminar cliente
                string query = "DELETE FROM Cliente WHERE ID = @ID";

                // Crear comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetro
                    command.Parameters.AddWithValue("@ID", id);

                    // Ejecutar consulta
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el ID del cliente seleccionado
            int id = ObtenerIDSeleccionado();

            if (id > 0)
            {
                string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                string direccion = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                string telefono = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();

                // Asignar valores a los campos de texto
                txtNombre.Text = nombre;
                txtDireccion.Text = direccion;
                txtTelefono.Text = telefono;
            }
        }
        private void CargarClientes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Definimos la consulta SQL para seleccionar todos los clientes
                string consulta = "SELECT * FROM Cliente";

                // Creamos un SqlDataAdapter para ejecutar la consulta y llenar un DataTable con los resultados
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, connection);
                DataTable dataTable = new DataTable();

                // Llenamos el DataTable con los datos del adaptador
                adapter.Fill(dataTable);

                // Asignamos el DataTable como fuente de datos del DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }

        // Aquí podrías agregar los otros métodos para actualizar y eliminar clientes
    }

}
