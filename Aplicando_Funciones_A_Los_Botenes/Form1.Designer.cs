namespace Aplicando_Funciones_A_Los_Botenes
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
            CiudadesPasisesBox = new ListBox();
            BuscarBtn = new Button();
            Eliminarbtn = new Button();
            ModificarBtn = new Button();
            LimpiarBtn = new Button();
            BuscarTxt = new TextBox();
            SuspendLayout();
            // 
            // CiudadesPasisesBox
            // 
            CiudadesPasisesBox.FormattingEnabled = true;
            CiudadesPasisesBox.Location = new Point(26, 97);
            CiudadesPasisesBox.Name = "CiudadesPasisesBox";
            CiudadesPasisesBox.Size = new Size(388, 169);
            CiudadesPasisesBox.TabIndex = 0;
            CiudadesPasisesBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(26, 54);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(75, 23);
            BuscarBtn.TabIndex = 1;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // Eliminarbtn
            // 
            Eliminarbtn.Location = new Point(107, 54);
            Eliminarbtn.Name = "Eliminarbtn";
            Eliminarbtn.Size = new Size(75, 23);
            Eliminarbtn.TabIndex = 2;
            Eliminarbtn.Text = "Eliminar";
            Eliminarbtn.UseVisualStyleBackColor = true;
            Eliminarbtn.Click += Eliminarbtn_Click;
            // 
            // ModificarBtn
            // 
            ModificarBtn.Location = new Point(202, 54);
            ModificarBtn.Name = "ModificarBtn";
            ModificarBtn.Size = new Size(75, 23);
            ModificarBtn.TabIndex = 3;
            ModificarBtn.Text = "Modificar";
            ModificarBtn.UseVisualStyleBackColor = true;
            ModificarBtn.Click += ModificarBtn_Click;
            // 
            // LimpiarBtn
            // 
            LimpiarBtn.Location = new Point(306, 54);
            LimpiarBtn.Name = "LimpiarBtn";
            LimpiarBtn.Size = new Size(75, 23);
            LimpiarBtn.TabIndex = 4;
            LimpiarBtn.Text = "Limpiar";
            LimpiarBtn.UseVisualStyleBackColor = true;
            LimpiarBtn.Click += LimpiarBtn_Click;
            // 
            // BuscarTxt
            // 
            BuscarTxt.Location = new Point(26, 25);
            BuscarTxt.Name = "BuscarTxt";
            BuscarTxt.Size = new Size(100, 23);
            BuscarTxt.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 303);
            Controls.Add(BuscarTxt);
            Controls.Add(LimpiarBtn);
            Controls.Add(ModificarBtn);
            Controls.Add(Eliminarbtn);
            Controls.Add(BuscarBtn);
            Controls.Add(CiudadesPasisesBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CiudadesPasisesBox;
        private Button BuscarBtn;
        private Button Eliminarbtn;
        private Button ModificarBtn;
        private Button LimpiarBtn;
        private TextBox BuscarTxt;
    }
}
