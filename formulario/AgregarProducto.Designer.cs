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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "Sku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 111);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Litros";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 162);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Kilogramos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 201);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio Venta";
            // 
            // SkuTxt
            // 
            SkuTxt.Location = new Point(191, 27);
            SkuTxt.Name = "SkuTxt";
            SkuTxt.Size = new Size(100, 23);
            SkuTxt.TabIndex = 5;
            // 
            // DescripcionTxt
            // 
            DescripcionTxt.Location = new Point(191, 67);
            DescripcionTxt.Name = "DescripcionTxt";
            DescripcionTxt.Size = new Size(100, 23);
            DescripcionTxt.TabIndex = 6;
            // 
            // LitrosTxt
            // 
            LitrosTxt.Location = new Point(191, 111);
            LitrosTxt.Name = "LitrosTxt";
            LitrosTxt.Size = new Size(100, 23);
            LitrosTxt.TabIndex = 7;
            // 
            // KilogramosTxt
            // 
            KilogramosTxt.Location = new Point(191, 165);
            KilogramosTxt.Name = "KilogramosTxt";
            KilogramosTxt.Size = new Size(100, 23);
            KilogramosTxt.TabIndex = 8;
            // 
            // PrecioVentaTxt
            // 
            PrecioVentaTxt.Location = new Point(191, 201);
            PrecioVentaTxt.Name = "PrecioVentaTxt";
            PrecioVentaTxt.Size = new Size(100, 23);
            PrecioVentaTxt.TabIndex = 9;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(27, 256);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(75, 23);
            AgregarBtn.TabIndex = 10;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // LimpiarBtn
            // 
            LimpiarBtn.Location = new Point(216, 256);
            LimpiarBtn.Name = "LimpiarBtn";
            LimpiarBtn.Size = new Size(75, 23);
            LimpiarBtn.TabIndex = 11;
            LimpiarBtn.Text = "Limpiar";
            LimpiarBtn.UseVisualStyleBackColor = true;
            LimpiarBtn.Click += LimpiarBtn_Click;
            // 
            // SalirBtn
            // 
            SalirBtn.Location = new Point(312, 256);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(75, 23);
            SalirBtn.TabIndex = 12;
            SalirBtn.Text = "Salir";
            SalirBtn.UseVisualStyleBackColor = true;
            SalirBtn.Click += SalirBtn_Click;
            // 
            // ProductoActualizar
            // 
            ProductoActualizar.Location = new Point(130, 259);
            ProductoActualizar.Name = "ProductoActualizar";
            ProductoActualizar.Size = new Size(75, 23);
            ProductoActualizar.TabIndex = 13;
            ProductoActualizar.Text = "ActualizarP";
            ProductoActualizar.UseVisualStyleBackColor = true;
            ProductoActualizar.Click += ProductoActualizar_Click;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 320);
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
    }
}