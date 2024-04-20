namespace otratarea
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(416, 201);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(587, 359);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 31);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 12F);
            btnActualizar.Location = new Point(470, 359);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 31);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(349, 359);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 31);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(28, 217);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 19;
            label4.Text = "Nro Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(28, 136);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 18;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(28, 47);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 17;
            label2.Text = "Nombre Completo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(28, 245);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(206, 23);
            txtTelefono.TabIndex = 16;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(28, 164);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(206, 23);
            txtDireccion.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(206, 23);
            txtNombre.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 18);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 13;
            label1.Text = "Lista de los clientes";
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Cliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label1;
    }
}