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
    public partial class RegistroProveedor : Form
    {
        public RegistroProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
