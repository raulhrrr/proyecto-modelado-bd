using System;
using System.Windows.Forms;

namespace ClientesProveedores
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        public void GuardarProducto(Producto producto)
        {
            if (producto.Id == 0)
            {
                _dataAccessLayer.GuardarProducto(producto);
            }
            else
            {
                _dataAccessLayer.ActualizarProducto(producto);
            }
        }

        public void RegistrarProveedor(Proveedor proveedor)
        {
            _dataAccessLayer.RegistrarProveedor(proveedor);
        }

        public bool ValidarDatosIngreso(string usuario, string contrasena)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("El usuario y la contraseña son campos requeridos", "¡Advertencia!");
                return false;
            }

            if (!_dataAccessLayer.ValidarDatosIngreso(usuario, contrasena))
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
                return false;
            }

            return true;
        }
    }
}
