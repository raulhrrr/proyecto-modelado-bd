using System;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public partial class RegistroProveedor : Form
    {
        private BusinessLogicLayer _businessLogicLayer;

        public RegistroProveedor()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Nombre = txtNombre.Text;
            proveedor.Apellido = txtApellido.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Email = txtEmail.Text;
            proveedor.NitCed = txtNitCed.Text;
            proveedor.Contrasena = txtContrasena.Text;

            _businessLogicLayer.RegistrarProveedor(proveedor);

            this.Hide();
            IngresoProveedor ingresoProveedor = new IngresoProveedor();
            ingresoProveedor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresoProveedor ingresoProveedor = new IngresoProveedor();
            ingresoProveedor.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNitCed_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
