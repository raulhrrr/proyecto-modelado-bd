using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace ClientesProveedores
{
    public class DataAccessLayer
    {
        private SqlConnection connection = new SqlConnection("Data Source = localhost; Initial Catalog = proyecto_clientes_proveedores; User ID = sa; Password=yourStrong(!)Password");

        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
        
        public void GuardarProducto(Producto producto)
        {
            try
            {
                connection.Open();
                string query = @"INSERT INTO producto (id_proveedor, nombre, precio, cantidad) 
                                VALUES (@IdProveedor, @Nombre, @Precio, @Cantidad)";

                SqlParameter idProveedor = new SqlParameter("@IdProveedor", producto.IdProveedor);
                SqlParameter nombre = new SqlParameter("@Nombre", producto.Nombre);
                SqlParameter precio = new SqlParameter("@Precio", producto.Precio);
                SqlParameter cantidad = new SqlParameter("@Cantidad", producto.Cantidad);

                SqlCommand command = new SqlCommand(query, connection);
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
                connection.Open();
                string query = @"INSERT INTO proveedor (nombre, apellido, direccion, telefono, email, nit_ced, contrasena)
                            VALUES (@Nombre, @Apellido, @Direccion, @Telefono, @Email, @NitCed, @Contrasena)";

                SqlParameter nombre = new SqlParameter("@Nombre", proveedor.Nombre);
                SqlParameter apellido = new SqlParameter("@Apellido", proveedor.Apellido);
                SqlParameter direccion = new SqlParameter("@Direccion", proveedor.Direccion);
                SqlParameter telefono = new SqlParameter("@Telefono", proveedor.Telefono);
                SqlParameter email = new SqlParameter("@Email", proveedor.Email);
                SqlParameter nitced = new SqlParameter("@NitCed", proveedor.NitCed);
                SqlParameter contrasena = new SqlParameter("@Contrasena", proveedor.Contrasena);

                SqlCommand command = new SqlCommand(query, connection);
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

        public void ActualizarProveedor(Proveedor proveedor)
        {
            try
            {
                connection.Open();
                string query = @"UPDATE proveedor
                                SET nombre = @Nombre, apellido = @Apellido, direccion = @Direccion, telefono = @Telefono, email = @Email, nit_ced = @NitCed, contrasena = @Contrasena
                                WHERE id = @IdProveedor";
                
                SqlParameter id = new SqlParameter("@IdProveedor", proveedor.Id);
                SqlParameter nombre = new SqlParameter("@Nombre", proveedor.Nombre);
                SqlParameter apellido = new SqlParameter("@Apellido", proveedor.Apellido);
                SqlParameter direccion = new SqlParameter("@Direccion", proveedor.Direccion);
                SqlParameter telefono = new SqlParameter("@Telefono", proveedor.Telefono);
                SqlParameter email = new SqlParameter("@Email", proveedor.Email);
                SqlParameter nitced = new SqlParameter("@NitCed", proveedor.NitCed);
                SqlParameter contrasena = new SqlParameter("@Contrasena", proveedor.Contrasena);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(id);
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
                connection.Open();
                string query = @"SELECT CASE WHEN p.contrasena = @Contrasena THEN 1 ELSE 0 END AS id
                                FROM proveedor p WHERE p.nit_ced = @NitCed";

                SqlParameter usuario = new SqlParameter("@NitCed", usuarioProveedor);
                SqlParameter contrasena = new SqlParameter("@Contrasena", contrasenaProveedor);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(usuario);
                command.Parameters.Add(contrasena);

                SqlDataReader reader = command.ExecuteReader();

                bool confirmacion = false;
                
                while (reader.Read())
                {
                    confirmacion = (int.Parse(reader["id"].ToString()) == 1);
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

        public int ObtenerIdProveedor(string usuarioProveedor, string contrasenaProveedor)
        {
            try
            {
                connection.Open();
                string query = @"SELECT id FROM proveedor p WHERE p.nit_ced = @NitCed AND p.contrasena = @Contrasena";

                SqlParameter usuario = new SqlParameter("@NitCed", usuarioProveedor);
                SqlParameter contrasena = new SqlParameter("@Contrasena", contrasenaProveedor);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(usuario);
                command.Parameters.Add(contrasena);

                SqlDataReader reader = command.ExecuteReader();

                int id = 0;

                while (reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());
                }

                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return 0;
        }

        public Proveedor ObtenerDatosProveedor(int idProveedor)
        {
            try
            {
                connection.Open();
                string query = @"SELECT p.nombre, p.apellido, p.direccion, p.telefono, p.email, p.nit_ced, p.contrasena
                                FROM proveedor p WHERE p.id = @IdProveedor";

                SqlParameter usuario = new SqlParameter("@IdProveedor", idProveedor);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(usuario);

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                string nombre = reader["nombre"].ToString();
                string apellido = reader["apellido"].ToString();
                string direccion = reader["direccion"].ToString();
                string telefono = reader["telefono"].ToString();
                string email = reader["email"].ToString();
                string nit_ced = reader["nit_ced"].ToString();
                string contrasena = reader["contrasena"].ToString();

                Proveedor proveedor = new Proveedor();
                proveedor.Id = idProveedor;
                proveedor.Nombre = nombre;
                proveedor.Apellido = apellido;
                proveedor.Direccion = direccion;
                proveedor.Telefono = telefono;
                proveedor.Email = email;
                proveedor.NitCed = nit_ced;
                proveedor.Contrasena = contrasena;

                return proveedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return null;
        }

        internal List<Producto> ObtenerProductosPorIdProveedor(int idProveedor)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                connection.Open();
                string query = @"SELECT id, id_proveedor, nombre, precio, cantidad
                                FROM producto WHERE id_proveedor = @IdProveedor";

                SqlParameter id = new SqlParameter("@IdProveedor", idProveedor);

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(id);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    productos.Add(new Producto
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        IdProveedor = int.Parse(reader["id_proveedor"].ToString()),
                        Nombre = reader["nombre"].ToString(),
                        Precio = decimal.Parse(reader["precio"].ToString()),
                        Cantidad = int.Parse(reader["cantidad"].ToString())
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return productos;
        }

        internal List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            try
            {
                connection.Open();
                string query = @"SELECT id, nombre, apellido, direccion, telefono, email, nit_ced
                                FROM proveedor";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    proveedores.Add(new Proveedor
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Direccion = reader["direccion"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        Email = reader["email"].ToString(),
                        NitCed = reader["nit_ced"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return proveedores;
        }
    }
}
