namespace Proyecto_Usuario_Universidad
{
    partial class Inicio_Sesion
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            CorreoElectronicoTxt = new TextBox();
            ContraseniaTxt = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 362);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(314, 366);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 175);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 246);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // CorreoElectronicoTxt
            // 
            CorreoElectronicoTxt.Location = new Point(320, 165);
            CorreoElectronicoTxt.Name = "CorreoElectronicoTxt";
            CorreoElectronicoTxt.Size = new Size(100, 23);
            CorreoElectronicoTxt.TabIndex = 4;
            // 
            // ContraseniaTxt
            // 
            ContraseniaTxt.Location = new Point(320, 256);
            ContraseniaTxt.Name = "ContraseniaTxt";
            ContraseniaTxt.Size = new Size(100, 23);
            ContraseniaTxt.TabIndex = 5;
            // 
            // Inicio_Sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 424);
            Controls.Add(ContraseniaTxt);
            Controls.Add(CorreoElectronicoTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Inicio_Sesion";
            Text = "Inicio_Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox CorreoElectronicoTxt;
        private TextBox ContraseniaTxt;
    }
}