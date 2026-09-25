namespace ProyectoPerro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ConfirmarBtn = new Button();
            SalirBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            NombreDelPerroTxt = new TextBox();
            ResultadoNombreTxt = new TextBox();
            LimpiarBtn = new Button();
            SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(40, 286);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(75, 23);
            ConfirmarBtn.TabIndex = 0;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // SalirBtn
            // 
            SalirBtn.Location = new Point(245, 293);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(75, 23);
            SalirBtn.TabIndex = 1;
            SalirBtn.Text = "Salir";
            SalirBtn.UseVisualStyleBackColor = true;
            SalirBtn.Click += SalirBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 51);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre Del Perro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 141);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 3;
            label2.Text = "Resultado del nombre";
            // 
            // NombreDelPerroTxt
            // 
            NombreDelPerroTxt.Location = new Point(196, 49);
            NombreDelPerroTxt.Name = "NombreDelPerroTxt";
            NombreDelPerroTxt.Size = new Size(100, 23);
            NombreDelPerroTxt.TabIndex = 4;
            // 
            // ResultadoNombreTxt
            // 
            ResultadoNombreTxt.Location = new Point(196, 141);
            ResultadoNombreTxt.Name = "ResultadoNombreTxt";
            ResultadoNombreTxt.Size = new Size(100, 23);
            ResultadoNombreTxt.TabIndex = 5;
            // 
            // LimpiarBtn
            // 
            LimpiarBtn.Location = new Point(150, 288);
            LimpiarBtn.Name = "LimpiarBtn";
            LimpiarBtn.Size = new Size(75, 23);
            LimpiarBtn.TabIndex = 6;
            LimpiarBtn.Text = "Limpiar";
            LimpiarBtn.UseVisualStyleBackColor = true;
            LimpiarBtn.Click += LimpiarBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 352);
            Controls.Add(LimpiarBtn);
            Controls.Add(ResultadoNombreTxt);
            Controls.Add(NombreDelPerroTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SalirBtn);
            Controls.Add(ConfirmarBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmarBtn;
        private Button SalirBtn;
        private Label label1;
        private Label label2;
        private TextBox NombreDelPerroTxt;
        private TextBox ResultadoNombreTxt;
        private Button LimpiarBtn;
    }
}
