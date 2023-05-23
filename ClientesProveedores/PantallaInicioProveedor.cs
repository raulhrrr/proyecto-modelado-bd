using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public partial class PantallaInicioProveedor : Form
    {
        private readonly int IdProveedor;
        private readonly BusinessLogicLayer _businessLogicLayer;

        public PantallaInicioProveedor(int idProveedor)
        {
            InitializeComponent();
            IdProveedor = idProveedor;
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void PantallaInicioProveedor_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        public void CargarProductos()
        {
            List<Producto> productos = _businessLogicLayer.ObtenerProductosPorIdProveedor(IdProveedor);
            dataGridView1.DataSource = productos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosProveedor datosProveedor = new DatosProveedor(IdProveedor);
            datosProveedor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnadirProducto anadirProducto = new AnadirProducto(IdProveedor);
            anadirProducto.ShowDialog(this);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Hide();
            IngresarComo ingresarComo = new IngresarComo();
            ingresarComo.Show();
        }
    }
}
