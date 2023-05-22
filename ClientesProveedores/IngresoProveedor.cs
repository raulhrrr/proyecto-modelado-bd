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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
                PantallaInicioProveedor pantallaInicioProveedor = new PantallaInicioProveedor();
                pantallaInicioProveedor.Show();
            };
        }
    }
}
