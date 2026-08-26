namespace Practicando_Diccionario_Diccionario
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
            ListaPrueba = new ListBox();
            SuspendLayout();
            // 
            // ListaPrueba
            // 
            ListaPrueba.FormattingEnabled = true;
            ListaPrueba.Location = new Point(12, 88);
            ListaPrueba.Name = "ListaPrueba";
            ListaPrueba.Size = new Size(499, 184);
            ListaPrueba.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 286);
            Controls.Add(ListaPrueba);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListaPrueba;
    }
}
