namespace ProyectoPerro
{
    public partial class Form1 : Form
    {
        string[] NombreDelPerro = new string[3];
        int AcumuladorDelNombre = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            Random AlzarNombre = new Random();
            if (NombreDelPerroTxt.Text != "")
            {


                NombreDelPerro[AcumuladorDelNombre] = NombreDelPerroTxt.Text;

                AcumuladorDelNombre++;

                NombreDelPerroTxt.Clear();
                if (AcumuladorDelNombre == 3)
                {
                    int posicionRamdon = AlzarNombre.Next(0, 3);
                    MessageBox.Show("El nombre del perro selescciona es: " + NombreDelPerro[posicionRamdon]);
                    ResultadoNombreTxt.Text = NombreDelPerro[posicionRamdon];

                    AcumuladorDelNombre = 0;
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un nombre ");
            }
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            ResultadoNombreTxt.Clear();
        }
    }
}
