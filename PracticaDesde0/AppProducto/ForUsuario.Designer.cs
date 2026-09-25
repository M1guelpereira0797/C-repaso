namespace AppProducto
{
    partial class ForUsuario
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
            RegistrarseLink = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            TxtUsuario = new TextBox();
            ContraseniaTxt = new TextBox();
            CambioContrasenia = new LinkLabel();
            IngresoBtn = new Button();
            CerrarBtn = new Button();
            SuspendLayout();
            // 
            // RegistrarseLink
            // 
            RegistrarseLink.AutoSize = true;
            RegistrarseLink.LinkColor = Color.Black;
            RegistrarseLink.Location = new Point(170, 299);
            RegistrarseLink.Name = "RegistrarseLink";
            RegistrarseLink.Size = new Size(64, 15);
            RegistrarseLink.TabIndex = 3;
            RegistrarseLink.TabStop = true;
            RegistrarseLink.Text = "Registrarse";
            RegistrarseLink.LinkClicked += RegistrarseLink_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 89);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 189);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(158, 136);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(100, 23);
            TxtUsuario.TabIndex = 7;
            // 
            // ContraseniaTxt
            // 
            ContraseniaTxt.Location = new Point(158, 245);
            ContraseniaTxt.Name = "ContraseniaTxt";
            ContraseniaTxt.Size = new Size(100, 23);
            ContraseniaTxt.TabIndex = 8;
            // 
            // CambioContrasenia
            // 
            CambioContrasenia.AutoSize = true;
            CambioContrasenia.LinkColor = Color.Black;
            CambioContrasenia.Location = new Point(121, 335);
            CambioContrasenia.Name = "CambioContrasenia";
            CambioContrasenia.Size = new Size(183, 15);
            CambioContrasenia.TabIndex = 9;
            CambioContrasenia.TabStop = true;
            CambioContrasenia.Text = "¿Se te ha olvidado la contraseña? ";
            // 
            // IngresoBtn
            // 
            IngresoBtn.Location = new Point(27, 408);
            IngresoBtn.Name = "IngresoBtn";
            IngresoBtn.Size = new Size(75, 23);
            IngresoBtn.TabIndex = 10;
            IngresoBtn.Text = "Ingresar";
            IngresoBtn.UseVisualStyleBackColor = true;
            // 
            // CerrarBtn
            // 
            CerrarBtn.Location = new Point(279, 408);
            CerrarBtn.Name = "CerrarBtn";
            CerrarBtn.Size = new Size(75, 23);
            CerrarBtn.TabIndex = 11;
            CerrarBtn.Text = "Salir";
            CerrarBtn.UseVisualStyleBackColor = true;
            // 
            // ForUsuario
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(404, 470);
            ControlBox = false;
            Controls.Add(CerrarBtn);
            Controls.Add(IngresoBtn);
            Controls.Add(CambioContrasenia);
            Controls.Add(ContraseniaTxt);
            Controls.Add(TxtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegistrarseLink);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ForUsuario";
            Text = "Usuario";
            Load += ForUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private LinkLabel Contraseña;
        private LinkLabel RegistrarseLink;
        private Label label1;
        private Label label2;
        
        private TextBox TxtUsuario;
        private TextBox ContraseniaTxt;
        private LinkLabel CambioContrasenia;
        private Button IngresoBtn;
        private Button CerrarBtn;
    }
}