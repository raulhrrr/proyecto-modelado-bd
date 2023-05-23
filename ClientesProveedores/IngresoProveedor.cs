using System;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public partial class IngresoProveedor : Form
    {
        private BusinessLogicLayer _businessLogicLayer;

        public IngresoProveedor()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistroProveedor registroProveedor = new RegistroProveedor();
            registroProveedor.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (_businessLogicLayer.ValidarDatosIngreso(txtUsuario.Text, txtContrasena.Text))
            {
                this.Hide();

                int idProveedor = _businessLogicLayer.ObtenerIdProveeedor(txtUsuario.Text, txtContrasena.Text);

                PantallaInicioProveedor pantallaInicioProveedor = new PantallaInicioProveedor(idProveedor);
                pantallaInicioProveedor.Show();
            };
        }
    }
}
