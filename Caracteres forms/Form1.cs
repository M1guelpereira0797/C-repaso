namespace Caracteres_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Caracter = "ABCDEFGHIJKLMNÑOPQRSTUVXYZ123456789";

            string contraseña = "";

            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                int posicion = random.Next(Caracter.Length);
                contraseña += Caracter[posicion];
            }

            CaracteresTxt.Text = contraseña;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> carro = new List<int>();
            int numero = (int)numericUpDown1.Value;

            

            

                carro.Add(numero);
            
            string mensaje = "El número seleccionado es: " + string.Join(", ", carro);

            MessageBox.Show(mensaje);

        }
    }
}
