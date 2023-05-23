using System;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public partial class AnadirProducto : Form
    {
        private readonly int IdProveedor;
        private BusinessLogicLayer _businessLogicLayer;

        public AnadirProducto(int idProveedor)
        {
            InitializeComponent();
            IdProveedor = idProveedor;
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btgGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecioU.Text) || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Todos los campos son requeridos", "¡Advertencia!");
                return;
            }

            Producto producto = new Producto();
            producto.IdProveedor = IdProveedor;
            producto.Nombre = txtNombre.Text;
            producto.Precio = decimal.Parse(txtPrecioU.Text);
            producto.Cantidad = int.Parse(txtCantidad.Text);

            _businessLogicLayer.GuardarProducto(producto);
            this.Close();
            ((PantallaInicioProveedor) this.Owner).CargarProductos();
        }

        private void AnadirProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
