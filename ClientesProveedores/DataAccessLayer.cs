using System;
using System.Data.SqlClient;

namespace ClientesProveedores
{
    public class DataAccessLayer
    {
        private SqlConnection _connection = new SqlConnection("Data Source = localhost; Initial Catalog = proyecto; User ID = sa; Password=yourStrong(!)Password");

        public void CloseConnection()
        {
            if (_connection != null)
            {
                _connection.Close();
            }
        }
        
        public void GuardarProducto(Producto producto)
        {
            try
            {
                _connection.Open();
                string query = @"INSERT INTO producto (id_proveedor, nombre, precio, cantidad) 
                                VALUES (@IdProveedor, @Nombre, @Precio, @Cantidad)";

                SqlParameter idProveedor = new SqlParameter("@IdProveedor", 1);
                SqlParameter nombre = new SqlParameter("@Nombre", producto.Nombre);
                SqlParameter precio = new SqlParameter("@Precio", producto.Precio);
                SqlParameter cantidad = new SqlParameter("@Cantidad", producto.Cantidad);

                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.Add(idProveedor);
                command.Parameters.Add(nombre);
                command.Parameters.Add(precio);
                command.Parameters.Add(cantidad);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void ActualizarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void RegistrarProveedor(Proveedor proveedor)
        {
            try
            {
                _connection.Open();
                string query = @"INSERT INTO proveedor (nombre, apellido, direccion, telefono, email, nit_ced, contrasena)
                            VALUES (@Nombre, @Apellido, @Direccion, @Telefono, @Email, @NitCed, @Contrasena)";

                SqlParameter nombre = new SqlParameter("@Nombre", proveedor.Nombre);
                SqlParameter apellido = new SqlParameter("@Apellido", proveedor.Apellido);
                SqlParameter direccion = new SqlParameter("@Direccion", proveedor.Direccion);
                SqlParameter telefono = new SqlParameter("@Telefono", proveedor.Telefono);
                SqlParameter email = new SqlParameter("@Email", proveedor.Email);
                SqlParameter nitced = new SqlParameter("@NitCed", proveedor.NitCed);
                SqlParameter contrasena = new SqlParameter("@Contrasena", proveedor.Contrasena);

                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.Add(nombre);
                command.Parameters.Add(apellido);
                command.Parameters.Add(direccion);
                command.Parameters.Add(telefono);
                command.Parameters.Add(email);
                command.Parameters.Add(nitced);
                command.Parameters.Add(contrasena);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool ValidarDatosIngreso(string usuarioProveedor, string contrasenaProveedor)
        {
            try
            {
                _connection.Open();
                string query = @"SELECT CASE WHEN p.contrasena = @Contrasena THEN 1 ELSE 0 END AS confirmacion
                                FROM proveedor p WHERE p.nit_ced = @NitCed";

                SqlParameter usuario = new SqlParameter("@NitCed", usuarioProveedor);
                SqlParameter contrasena = new SqlParameter("@Contrasena", contrasenaProveedor);

                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.Add(usuario);
                command.Parameters.Add(contrasena);

                SqlDataReader reader = command.ExecuteReader();

                bool confirmacion = false;
                
                while (reader.Read())
                {
                    confirmacion = ((int) reader["confirmacion"] == 1);
                }

                return confirmacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
    }
}
