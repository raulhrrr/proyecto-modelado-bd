using System;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public partial class ListadoProveedores : Form
    {
        public ListadoProveedores()
        {
            InitializeComponent();
        }

        private void ListadoProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresarComo ingresarComo = new IngresarComo();
            ingresarComo.Show();
        }
    }
}
