namespace otratarea
{
    partial class Productos
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            label1 = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCategoria = new TextBox();
            txtBuscar = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 0;
            label1.Text = "Todos los poductos ";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 39);
            txtNombre.TabIndex = 1;
           
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(40, 135);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(211, 39);
            txtPrecio.TabIndex = 2;
            
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(40, 216);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(211, 39);
            txtCategoria.TabIndex = 3;
            
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(775, 37);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(154, 39);
            txtBuscar.TabIndex = 4;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(40, 18);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
          
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(40, 107);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 6;
            label3.Text = "Precio";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(40, 188);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 7;
            label4.Text = "categoria";
           
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(779, 9);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 8;
            label5.Text = "Buscar producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(325, 307);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 31);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(446, 307);
            button2.Name = "button2";
            button2.Size = new Size(100, 31);
            button2.TabIndex = 10;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(563, 307);
            button3.Name = "button3";
            button3.Size = new Size(100, 31);
            button3.TabIndex = 11;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.BackColor = Color.FromArgb(128, 255, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(416, 201);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBuscar);
            Controls.Add(txtCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCategoria;
        private TextBox txtBuscar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
    }
}