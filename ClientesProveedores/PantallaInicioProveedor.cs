using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public partial class PantallaInicioProveedor : Form
    {
        public PantallaInicioProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosProveedor datosProveedor = new DatosProveedor();
            datosProveedor.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnadirProducto anadirProducto = new AnadirProducto();
            anadirProducto.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Hide();
            IngresarComo ingresarComo = new IngresarComo();
            ingresarComo.Show();
        }
    }
}
