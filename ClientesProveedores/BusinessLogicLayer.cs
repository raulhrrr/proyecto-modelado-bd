using System;
using System.Collections.Generic;
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
            if (proveedor.Id == 0)
            {
                _dataAccessLayer.RegistrarProveedor(proveedor);
            }
            else
            {
                _dataAccessLayer.ActualizarProveedor(proveedor);
            }
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
                MessageBox.Show("Usuario o contraseña incorrecto", "¡Advertencia!");
                return false;
            }

            return true;
        }

        public int ObtenerIdProveeedor(string usuario, string contrasena)
        {
            return _dataAccessLayer.ObtenerIdProveedor(usuario, contrasena);
        }

        public Proveedor ObtenerDatosProveedor(int idProveedor)
        {
            return _dataAccessLayer.ObtenerDatosProveedor(idProveedor);
        }

        public List<Producto> ObtenerProductosPorIdProveedor(int idProveedor)
        {
            return _dataAccessLayer.ObtenerProductosPorIdProveedor(idProveedor);
        }

        internal List<Proveedor> ObtenerProveedores()
        {
            return _dataAccessLayer.ObtenerProveedores();
        }
    }
}
