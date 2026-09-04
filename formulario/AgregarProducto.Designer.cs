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
            BtnAgregar = new Button();
            BtnLimpiar = new Button();
            BtnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SkuTxt = new TextBox();
            DescripcionTxt = new TextBox();
            CostoTxt = new TextBox();
            PrecioVentaTxt = new TextBox();
            label5 = new Label();
            StockTxt = new TextBox();
            IdUsuarioTxt = new TextBox();
            IdUsuario = new Label();
            SuspendLayout();
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(29, 344);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(261, 344);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 1;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(470, 344);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 2;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 3;
            label1.Text = "Sku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 100);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 178);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Costo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 220);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio_Venta";
            // 
            // SkuTxt
            // 
            SkuTxt.Location = new Point(252, 42);
            SkuTxt.Name = "SkuTxt";
            SkuTxt.Size = new Size(100, 23);
            SkuTxt.TabIndex = 7;
            // 
            // DescripcionTxt
            // 
            DescripcionTxt.Location = new Point(252, 100);
            DescripcionTxt.Name = "DescripcionTxt";
            DescripcionTxt.Size = new Size(100, 23);
            DescripcionTxt.TabIndex = 8;
            // 
            // CostoTxt
            // 
            CostoTxt.Location = new Point(252, 170);
            CostoTxt.Name = "CostoTxt";
            CostoTxt.Size = new Size(100, 23);
            CostoTxt.TabIndex = 9;
            // 
            // PrecioVentaTxt
            // 
            PrecioVentaTxt.Location = new Point(252, 212);
            PrecioVentaTxt.Name = "PrecioVentaTxt";
            PrecioVentaTxt.Size = new Size(100, 23);
            PrecioVentaTxt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 257);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Stock";
            // 
            // StockTxt
            // 
            StockTxt.Location = new Point(252, 249);
            StockTxt.Name = "StockTxt";
            StockTxt.Size = new Size(100, 23);
            StockTxt.TabIndex = 12;
            // 
            // IdUsuarioTxt
            // 
            IdUsuarioTxt.Location = new Point(252, 295);
            IdUsuarioTxt.Name = "IdUsuarioTxt";
            IdUsuarioTxt.Size = new Size(100, 23);
            IdUsuarioTxt.TabIndex = 13;
            // 
            // IdUsuario
            // 
            IdUsuario.AutoSize = true;
            IdUsuario.Location = new Point(29, 303);
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Size = new Size(38, 15);
            IdUsuario.TabIndex = 14;
            IdUsuario.Text = "label6";
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 385);
            Controls.Add(IdUsuario);
            Controls.Add(IdUsuarioTxt);
            Controls.Add(StockTxt);
            Controls.Add(label5);
            Controls.Add(PrecioVentaTxt);
            Controls.Add(CostoTxt);
            Controls.Add(DescripcionTxt);
            Controls.Add(SkuTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSalir);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnAgregar);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregar;
        private Button BtnLimpiar;
        private Button BtnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SkuTxt;
        private TextBox DescripcionTxt;
        private TextBox CostoTxt;
        private TextBox PrecioVentaTxt;
        private Label label5;
        private TextBox StockTxt;
        private TextBox IdUsuarioTxt;
        private Label IdUsuario;
    }
}