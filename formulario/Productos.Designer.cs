namespace formulario
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
            dataGridView1 = new DataGridView();
            cmbBx = new ComboBox();
            BtnBuscar = new Button();
            BtnAgregarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(526, 262);
            dataGridView1.TabIndex = 0;
            // 
            // cmbBx
            // 
            cmbBx.FormattingEnabled = true;
            cmbBx.Items.AddRange(new object[] { "Maipu", "Carlos Valdovinos", "Puente Alto" });
            cmbBx.Location = new Point(17, 18);
            cmbBx.Name = "cmbBx";
            cmbBx.Size = new Size(138, 23);
            cmbBx.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(207, 17);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnAgregarProducto
            // 
            BtnAgregarProducto.Location = new Point(315, 15);
            BtnAgregarProducto.Name = "BtnAgregarProducto";
            BtnAgregarProducto.Size = new Size(140, 23);
            BtnAgregarProducto.TabIndex = 3;
            BtnAgregarProducto.Text = "Agregar Producto";
            BtnAgregarProducto.UseVisualStyleBackColor = true;
            BtnAgregarProducto.Click += BtnAgregar_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 365);
            Controls.Add(BtnAgregarProducto);
            Controls.Add(BtnBuscar);
            Controls.Add(cmbBx);
            Controls.Add(dataGridView1);
            Name = "Productos";
            Text = "Producto";
            Load += Producto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbBx;
        private Button BtnBuscar;
        private Button BtnAgregarProducto;
    }
}