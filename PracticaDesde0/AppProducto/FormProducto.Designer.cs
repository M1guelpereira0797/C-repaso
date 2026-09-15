namespace AppProducto
{
    partial class FormProducto
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
            CentrosCmb = new ComboBox();
            AgregrarProductoBtn = new Button();
            RefrescarBtn = new Button();
            EliminarBtn = new Button();
            Actualizar_ProductoBtn = new Button();
            Buscar_CentroBtn = new Button();
            Salirbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(781, 283);
            dataGridView1.TabIndex = 0;
            // 
            // CentrosCmb
            // 
            CentrosCmb.FormattingEnabled = true;
            CentrosCmb.Items.AddRange(new object[] { "Carlos Valdovinos", "Maipu", "Puente Alto", "Renca" });
            CentrosCmb.Location = new Point(31, 31);
            CentrosCmb.Name = "CentrosCmb";
            CentrosCmb.Size = new Size(121, 23);
            CentrosCmb.TabIndex = 1;
            // 
            // AgregrarProductoBtn
            // 
            AgregrarProductoBtn.Location = new Point(31, 92);
            AgregrarProductoBtn.Name = "AgregrarProductoBtn";
            AgregrarProductoBtn.Size = new Size(121, 26);
            AgregrarProductoBtn.TabIndex = 2;
            AgregrarProductoBtn.Text = "Agregar Producto";
            AgregrarProductoBtn.UseVisualStyleBackColor = true;
            AgregrarProductoBtn.Click += AgregrarProductoBtn_Click;
            // 
            // RefrescarBtn
            // 
            RefrescarBtn.Location = new Point(379, 31);
            RefrescarBtn.Name = "RefrescarBtn";
            RefrescarBtn.Size = new Size(139, 23);
            RefrescarBtn.TabIndex = 3;
            RefrescarBtn.Text = "Refrescar";
            RefrescarBtn.UseVisualStyleBackColor = true;
            RefrescarBtn.Click += RefrescarBtn_Click;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(176, 94);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(139, 23);
            EliminarBtn.TabIndex = 4;
            EliminarBtn.Text = "Eliminar Producto";
            EliminarBtn.UseVisualStyleBackColor = true;
            EliminarBtn.Click += EliminarBtn_Click;
            // 
            // Actualizar_ProductoBtn
            // 
            Actualizar_ProductoBtn.Location = new Point(379, 94);
            Actualizar_ProductoBtn.Name = "Actualizar_ProductoBtn";
            Actualizar_ProductoBtn.Size = new Size(139, 24);
            Actualizar_ProductoBtn.TabIndex = 5;
            Actualizar_ProductoBtn.Text = "Actualizar Producto";
            Actualizar_ProductoBtn.UseVisualStyleBackColor = true;
            Actualizar_ProductoBtn.Click += Actualizar_ProductoBtn_Click;
            // 
            // Buscar_CentroBtn
            // 
            Buscar_CentroBtn.Location = new Point(176, 29);
            Buscar_CentroBtn.Name = "Buscar_CentroBtn";
            Buscar_CentroBtn.Size = new Size(139, 25);
            Buscar_CentroBtn.TabIndex = 6;
            Buscar_CentroBtn.Text = "Buscar Centro";
            Buscar_CentroBtn.UseVisualStyleBackColor = true;
            Buscar_CentroBtn.Click += Buscar_CentroBtn_Click;
            // 
            // Salirbtn
            // 
            Salirbtn.Location = new Point(604, 59);
            Salirbtn.Name = "Salirbtn";
            Salirbtn.Size = new Size(126, 36);
            Salirbtn.TabIndex = 7;
            Salirbtn.Text = "Salir";
            Salirbtn.UseVisualStyleBackColor = true;
            Salirbtn.Click += Salirbtn_Click;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Salirbtn);
            Controls.Add(Buscar_CentroBtn);
            Controls.Add(Actualizar_ProductoBtn);
            Controls.Add(EliminarBtn);
            Controls.Add(RefrescarBtn);
            Controls.Add(AgregrarProductoBtn);
            Controls.Add(CentrosCmb);
            Controls.Add(dataGridView1);
            Name = "FormProducto";
            Text = "Producto";
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox CentrosCmb;
        private Button AgregrarProductoBtn;
        private Button RefrescarBtn;
        private Button EliminarBtn;
        private Button Actualizar_ProductoBtn;
        private Button Buscar_CentroBtn;
        private Button Salirbtn;
    }
}