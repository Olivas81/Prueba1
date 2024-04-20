namespace otratarea
{
    partial class Venta
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
            btnAgregar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listBoxProductosSeleccionados = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(324, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(416, 201);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(449, 321);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(159, 31);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Realizar compra";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(384, 267);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 23);
            txtNombre.TabIndex = 26;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(384, -4);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 27;
            label2.Text = "Compra a realizar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(286, 265);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 28;
            label1.Text = "Cantidad";
            // 
            // listBoxProductosSeleccionados
            // 
            listBoxProductosSeleccionados.FormattingEnabled = true;
            listBoxProductosSeleccionados.ItemHeight = 15;
            listBoxProductosSeleccionados.Location = new Point(21, 50);
            listBoxProductosSeleccionados.Name = "listBoxProductosSeleccionados";
            listBoxProductosSeleccionados.Size = new Size(188, 124);
            listBoxProductosSeleccionados.TabIndex = 29;
            listBoxProductosSeleccionados.SelectedIndexChanged += listBoxProductosSeleccionados_SelectedIndexChanged;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxProductosSeleccionados);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Name = "Venta";
            Text = "Venta";
            Load += Venta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregar;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private ListBox listBoxProductosSeleccionados;
    }
}