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
    public partial class Productos : Form
    {
        public Productosa Productosa { get; set; }

        public Productos()
        {
            InitializeComponent();
            Productosa = new Productosa("Server=Wilson;Database=Super;Integrated Security=true;");

            // Asociar el evento KeyPress al TextBox de búsqueda
            txtBuscar.KeyPress += txtBuscar_KeyPress;

            // Mostrar todos los productos al cargar el formulario
            MostrarDatos();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var precio = Convert.ToInt32(txtPrecio.Text);
            var categoria = txtCategoria.Text;
            Productosa.InsertarProducto(nombre, precio, categoria);

            MostrarDatos();

            LimpiarCampos();
        }

        private void MostrarDatos()
        {
            DataTable dataTable = Productosa.ObtenerProductos();
            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns["ID"].ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                Productosa.EliminarProducto(id);
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = selectedRow.Cells["Precio"].Value.ToString();
                txtCategoria.Text = selectedRow.Cells["Categoria"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                string nombre = txtNombre.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                string categoria = txtCategoria.Text;
                Productosa.ActualizarProducto(id, nombre, precio, categoria);
                MostrarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCategoria.Clear();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarProductos(txtBuscar.Text);
            }
        }

        private void BuscarProductos(string criterio)
        {
            DataTable resultados = Productosa.BuscarProductos(criterio);
            dataGridView1.DataSource = resultados;
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

