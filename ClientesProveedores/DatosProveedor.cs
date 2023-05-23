using System;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public partial class DatosProveedor : Form
    {
        private readonly int IdProveedor;
        private readonly BusinessLogicLayer _businessLogicLayer;

        public DatosProveedor(int idProveedor)
        {
            InitializeComponent();
            IdProveedor = idProveedor;
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void DatosProveedor_Load(object sender, EventArgs e)
        {
            Proveedor proveedor = _businessLogicLayer.ObtenerDatosProveedor(IdProveedor);

            txtNombre.Text = proveedor.Nombre;
            txtApellido.Text = proveedor.Apellido;
            txtDireccion.Text = proveedor.Direccion;
            txtTelefono.Text = proveedor.Telefono;
            txtEmail.Text = proveedor.Email;
            txtNitCed.Text = proveedor.NitCed;
            txtContrasena.Text = proveedor.Contrasena;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Id = IdProveedor;
            proveedor.Nombre = txtNombre.Text;
            proveedor.Apellido = txtApellido.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Email = txtEmail.Text;
            proveedor.NitCed = txtNitCed.Text;
            proveedor.Contrasena = txtContrasena.Text;

            _businessLogicLayer.RegistrarProveedor(proveedor);

            this.Close();
        }

    }
}
