namespace Proyecto_Usuario_Universidad
{
    partial class Registro_Usuario
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SalirBtn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 55);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 97);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 2;
            label3.Text = "rut";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 142);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 179);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 4;
            label5.Text = "Codigo trabajador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 215);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "Sexo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 261);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 6;
            label7.Text = "Correo Electronico";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 307);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 7;
            label8.Text = "Contraseña";
            // 
            // SalirBtn
            // 
            SalirBtn.Location = new Point(41, 354);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(75, 23);
            SalirBtn.TabIndex = 8;
            SalirBtn.Text = "Salir";
            SalirBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(321, 359);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Registro_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 408);
            Controls.Add(button2);
            Controls.Add(SalirBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registro_Usuario";
            Text = "Registro_Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button SalirBtn;
        private Button button2;
    }
}