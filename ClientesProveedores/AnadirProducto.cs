using System;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public partial class AnadirProducto : Form
    {
        private BusinessLogicLayer _businessLogicLayer;

        public AnadirProducto()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btgGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = txtNombre.Text;
            producto.Precio = decimal.Parse(txtPrecioU.Text);
            producto.Cantidad = int.Parse(txtCantidad.Text);

            _businessLogicLayer.GuardarProducto(producto);
            this.Close();
        }

        private void AnadirProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
