using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VentasEx
{
    public partial class Form1 : Form
    {
        VentasRepository vent = new VentasRepository();
        List<infVentas> inf = new List<infVentas>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            int cantidad = Convert.ToInt32(txtCntd.Text);
            double Precio = Convert.ToDouble(txtPrice.Text);
            double ventast = cantidad * Precio;
            inf.Add(new infVentas(Name, Precio, cantidad, ventast));
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = inf;
            vent.GuardarDatosProdAsync(inf);
            vent.GetAllAsync();
        }
        }
    }


