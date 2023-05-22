using System;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public partial class IngresarComo : Form
    {
        public IngresarComo()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoProveedores proveedores = new ListadoProveedores();
            proveedores.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresoProveedor ingresoProveedor = new IngresoProveedor();
            ingresoProveedor.Show();
        }
    }
}
