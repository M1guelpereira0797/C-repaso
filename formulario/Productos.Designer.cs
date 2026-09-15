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
            BtnBuscar = new Button();
            BtnAgregarProducto = new Button();
            EliminarBtn = new Button();
            RefrescarBtn = new Button();
            ActuailzarBtn = new Button();
            BuscarIdTxt = new TextBox();
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
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(161, 17);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(85, 23);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnAgregarProducto
            // 
            BtnAgregarProducto.Location = new Point(253, 18);
            BtnAgregarProducto.Name = "BtnAgregarProducto";
            BtnAgregarProducto.Size = new Size(140, 23);
            BtnAgregarProducto.TabIndex = 3;
            BtnAgregarProducto.Text = "Agregar Producto";
            BtnAgregarProducto.UseVisualStyleBackColor = true;
            BtnAgregarProducto.Click += BtnAgregar_Click;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(399, 18);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(116, 23);
            EliminarBtn.TabIndex = 4;
            EliminarBtn.Text = "Eliminar Producto";
            EliminarBtn.UseVisualStyleBackColor = true;
            EliminarBtn.Click += EliminarBtn_Click;
            // 
            // RefrescarBtn
            // 
            RefrescarBtn.Location = new Point(161, 46);
            RefrescarBtn.Name = "RefrescarBtn";
            RefrescarBtn.Size = new Size(85, 23);
            RefrescarBtn.TabIndex = 5;
            RefrescarBtn.Text = "Refrescar";
            RefrescarBtn.UseVisualStyleBackColor = true;
            RefrescarBtn.Click += RefrescarBtn_Click;
            // 
            // ActuailzarBtn
            // 
            ActuailzarBtn.Location = new Point(253, 47);
            ActuailzarBtn.Name = "ActuailzarBtn";
            ActuailzarBtn.Size = new Size(140, 23);
            ActuailzarBtn.TabIndex = 6;
            ActuailzarBtn.Text = "Actualizar Producto";
            ActuailzarBtn.UseVisualStyleBackColor = true;
            ActuailzarBtn.Click += ActuailzarBtn_Click;
            // 
            // BuscarIdTxt
            // 
            BuscarIdTxt.Location = new Point(24, 19);
            BuscarIdTxt.Name = "BuscarIdTxt";
            BuscarIdTxt.Size = new Size(131, 23);
            BuscarIdTxt.TabIndex = 7;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 365);
            Controls.Add(BuscarIdTxt);
            Controls.Add(ActuailzarBtn);
            Controls.Add(RefrescarBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(BtnAgregarProducto);
            Controls.Add(BtnBuscar);
            Controls.Add(dataGridView1);
            Name = "Productos";
            Text = "Producto";
            Load += Producto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnBuscar;
        private Button BtnAgregarProducto;
        private Button EliminarBtn;
        private Button RefrescarBtn;
        private Button ActuailzarBtn;
        private TextBox BuscarIdTxt;
    }
}