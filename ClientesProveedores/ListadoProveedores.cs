using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public partial class ListadoProveedores : Form
    {
        private readonly BusinessLogicLayer _businessLogicLayer;

        public ListadoProveedores()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void ListadoProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        public void CargarProveedores()
        {
            List<Proveedor> proveedores = _businessLogicLayer.ObtenerProveedores();
            dataGridView1.DataSource = proveedores;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresarComo ingresarComo = new IngresarComo();
            ingresarComo.Show();
        }
    }
}
