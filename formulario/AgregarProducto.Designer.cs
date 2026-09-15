namespace formulario
{
    partial class AgregarProducto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SkuTxt = new TextBox();
            DescripcionTxt = new TextBox();
            LitrosTxt = new TextBox();
            KilogramosTxt = new TextBox();
            PrecioVentaTxt = new TextBox();
            AgregarBtn = new Button();
            LimpiarBtn = new Button();
            SalirBtn = new Button();
            ProductoActualizar = new Button();
            VolverBtn = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 111);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "Sku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 151);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 195);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Litros";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 246);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Kilogramos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 285);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio Venta";
            // 
            // SkuTxt
            // 
            SkuTxt.Location = new Point(194, 111);
            SkuTxt.Name = "SkuTxt";
            SkuTxt.Size = new Size(100, 23);
            SkuTxt.TabIndex = 5;
            // 
            // DescripcionTxt
            // 
            DescripcionTxt.Location = new Point(194, 151);
            DescripcionTxt.Name = "DescripcionTxt";
            DescripcionTxt.Size = new Size(100, 23);
            DescripcionTxt.TabIndex = 6;
            // 
            // LitrosTxt
            // 
            LitrosTxt.Location = new Point(194, 195);
            LitrosTxt.Name = "LitrosTxt";
            LitrosTxt.Size = new Size(100, 23);
            LitrosTxt.TabIndex = 7;
            // 
            // KilogramosTxt
            // 
            KilogramosTxt.Location = new Point(194, 249);
            KilogramosTxt.Name = "KilogramosTxt";
            KilogramosTxt.Size = new Size(100, 23);
            KilogramosTxt.TabIndex = 8;
            // 
            // PrecioVentaTxt
            // 
            PrecioVentaTxt.Location = new Point(194, 285);
            PrecioVentaTxt.Name = "PrecioVentaTxt";
            PrecioVentaTxt.Size = new Size(100, 23);
            PrecioVentaTxt.TabIndex = 9;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(21, 367);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(75, 23);
            AgregarBtn.TabIndex = 10;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // LimpiarBtn
            // 
            LimpiarBtn.Location = new Point(210, 367);
            LimpiarBtn.Name = "LimpiarBtn";
            LimpiarBtn.Size = new Size(75, 23);
            LimpiarBtn.TabIndex = 11;
            LimpiarBtn.Text = "Limpiar";
            LimpiarBtn.UseVisualStyleBackColor = true;
            LimpiarBtn.Click += LimpiarBtn_Click;
            // 
            // SalirBtn
            // 
            SalirBtn.Location = new Point(306, 367);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(75, 23);
            SalirBtn.TabIndex = 12;
            SalirBtn.Text = "Salir";
            SalirBtn.UseVisualStyleBackColor = true;
            SalirBtn.Click += SalirBtn_Click;
            // 
            // ProductoActualizar
            // 
            ProductoActualizar.Location = new Point(111, 367);
            ProductoActualizar.Name = "ProductoActualizar";
            ProductoActualizar.Size = new Size(75, 23);
            ProductoActualizar.TabIndex = 13;
            ProductoActualizar.Text = "ActualizarP";
            ProductoActualizar.UseVisualStyleBackColor = true;
            ProductoActualizar.Click += ProductoActualizar_Click;
            // 
            // VolverBtn
            // 
            VolverBtn.Location = new Point(161, 396);
            VolverBtn.Name = "VolverBtn";
            VolverBtn.Size = new Size(75, 23);
            VolverBtn.TabIndex = 14;
            VolverBtn.Text = "Vovler ";
            VolverBtn.UseVisualStyleBackColor = true;
            VolverBtn.Click += VolverBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Puente Alto", "Carlos Valdovinos", "Maipu", "Renca" });
            comboBox1.Location = new Point(191, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 44);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 16;
            label6.Text = "Centro";
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 459);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(VolverBtn);
            Controls.Add(ProductoActualizar);
            Controls.Add(SalirBtn);
            Controls.Add(LimpiarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(PrecioVentaTxt);
            Controls.Add(KilogramosTxt);
            Controls.Add(LitrosTxt);
            Controls.Add(DescripcionTxt);
            Controls.Add(SkuTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox SkuTxt;
        private TextBox DescripcionTxt;
        private TextBox LitrosTxt;
        private TextBox KilogramosTxt;
        private TextBox PrecioVentaTxt;
        private Button AgregarBtn;
        private Button LimpiarBtn;
        private Button SalirBtn;
        private Button ProductoActualizar;
        private Button VolverBtn;
        private ComboBox comboBox1;
        private Label label6;
    }
}