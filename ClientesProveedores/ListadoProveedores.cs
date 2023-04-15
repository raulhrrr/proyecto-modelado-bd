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
