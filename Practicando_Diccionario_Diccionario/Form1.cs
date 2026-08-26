namespace Practicando_Diccionario_Diccionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, Dictionary<string, double>> catalogoShop = new Dictionary<string, Dictionary<string, double>>();
            catalogoShop.Add("Electronics", new Dictionary<string, double> { {"telefono", 1000 }, {"Laptop", 2000 }, {" televisor", 3000 } });
        
            ListaPrueba.Items.Add("seccion \t\t\t Producto \t\t\t Precio");
            foreach(KeyValuePair<string, Dictionary<string, double>> seccion in catalogoShop)
            {
                ListaPrueba.Items.Add(seccion.Key);
                foreach (KeyValuePair<string, double> producto in seccion.Value)
                {
                    ListaPrueba.Items.Add("\t\t\t" + producto.Key +  "\t\t\t" + producto.Value);
                }
            }

        }
    }
}
