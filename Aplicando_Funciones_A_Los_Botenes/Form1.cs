namespace Aplicando_Funciones_A_Los_Botenes
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> CiudadesXporElMundo = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CiudadesXporElMundo.Add("Buenos aires", "Argentina");
            CiudadesXporElMundo.Add("Lima", "Peru");
            CiudadesXporElMundo.Add("Santiago", "Chile");
            CiudadesXporElMundo.Add("Montevideo", "Uruguay");

            foreach (KeyValuePair<string, string> item in CiudadesXporElMundo)
            {
                CiudadesPasisesBox.Items.Add(item.Key + "  -  " + item.Value);
            }
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            CiudadesPasisesBox.Items.Clear();

        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            if (CiudadesPasisesBox.SelectedItem != null)
            {
                CiudadesPasisesBox.Items.Remove(CiudadesPasisesBox.SelectedItem);
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            string buscar = BuscarTxt.Text;
            if (string.IsNullOrWhiteSpace(buscar))
            {
                MessageBox.Show("Por favor, ingrese un término de búsqueda.");
                return;
            }
            else if (CiudadesXporElMundo.ContainsKey(buscar))
            {
                string pais = CiudadesXporElMundo[buscar];
                MessageBox.Show($"La ciudad {buscar} se encuentra en el país {pais}.");
            }
            else

            {
                MessageBox.Show("Por favwwwwor, ingrese un término de búsqueda.");
                return;
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            string modificar = BuscarTxt.Text;
             
                if (!string.IsNullOrWhiteSpace(modificar))
            {
                MessageBox.Show("Ingrese los datos correctos");
                return;
            }
            else if (CiudadesXporElMundo.ContainsKey(modificar))
            {
                    
            }
            
        }
    }
}
