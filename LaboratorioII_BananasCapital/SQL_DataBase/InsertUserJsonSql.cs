using System.Data;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using BibliotecaClases.Usuarios_Tarjetas;
using BibliotecaClases.SQL_DataBase;
using static BibliotecaClases.Usuarios_Tarjetas.ClassTarjetaDebito;
using static BibliotecaClases.Usuarios_Tarjetas.ClassUsuarios;
using static BibliotecaClases.AccionesHard.Acciones;
using LaboratorioII_BananasCapital;

namespace BC_Formularios.SQL_DataBase
{
    internal class InsertUserJsonSql
    {
        private MySqlConnection conexion;
        TarjetaDebito deserializacion = new TarjetaDebito("Verificacion", "Verificacion", 0, 0, DateTime.Now);

        public InsertUserJsonSql()
        {
            ConexionDataBaseSql conexionSql = new ConexionDataBaseSql();
            this.conexion = conexionSql.EstableceConexionTest();
        }

        public void InsertarDataJson()
        {
            try
            {
                string rutaJson = @"E:\Progra-Labo II\LaboratorioII_BananasCapital_Parcial\LaboratorioII_BananasCapital\bin\Debug\net6.0-windows\UsuariosDataBase.json";

                if (File.Exists(rutaJson))
                {
                    string json = File.ReadAllText(rutaJson);


                    var listaUsuarios = JsonConvert.DeserializeObject<List<ClassUsuarios.User>>(json);

                    foreach (var userData in listaUsuarios)
                    {
                        if (!UsuarioExiste(userData.Username))
                        {
                            Insertar(userData);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo JSON no existe en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos desde JSON: " + ex.Message);
            }
        }

        public void InsertarDataXml()
        {
            try
            {


                string rutaXml = @"E:\Progra-Labo II\LaboratorioII_BananasCapital_Parcial\LaboratorioII_BananasCapital\bin\Debug\net6.0-windows\TarjetasDataBase.xml";

                if (File.Exists(rutaXml))
                {
                    string xml = File.ReadAllText(rutaXml);
                    var diccionarioTarjetas = deserializacion.Deserializacion(xml);

                    foreach (var tarjeta in diccionarioTarjetas.Values)
                    {
                        if (!TarjetaExiste(tarjeta.UsuarioOperario))
                        {
                            Insertar(tarjeta);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo XML no existe en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos desde XML: " + ex.Message);
            }
        }

        private void Insertar(ClassUsuarios.User userData)
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();

                string query = "INSERT INTO usuariobananas (Nombre, Apellido, Rol, FechaRegistro, Username, Contraseña, Email, DNI, Cuit_Cuil, Celular, Domicilio, CantidadAcciones, Saldo) " +
                               "VALUES (@Nombre, @Apellido, @Rol, @FechaRegistro, @Username, @Contraseña, @Email, @DNI, @Cuit_Cuil, @Celular, @Domicilio, @CantidadAcciones, @Saldo)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", userData.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", userData.Apellido);
                    cmd.Parameters.AddWithValue("@Rol", userData.Rol);
                    cmd.Parameters.AddWithValue("@FechaRegistro", userData.FechaRegistro);
                    cmd.Parameters.AddWithValue("@Username", userData.Username);
                    cmd.Parameters.AddWithValue("@Contraseña", userData.Contraseña);
                    cmd.Parameters.AddWithValue("@Email", userData.Email);
                    cmd.Parameters.AddWithValue("@DNI", userData.DNI);
                    cmd.Parameters.AddWithValue("@Cuit_Cuil", userData.Cuit_Cuil);
                    cmd.Parameters.AddWithValue("@Celular", userData.Celular);
                    cmd.Parameters.AddWithValue("@Domicilio", userData.Domicilio);
                    cmd.Parameters.AddWithValue("@CantidadAcciones", userData.CantidadAcciones);
                    cmd.Parameters.AddWithValue("@Saldo", userData.Saldo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos en la base de datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                MessageBox.Show("Se logro la conexion junto a la actualizacion de datos, procede a cerrarse ...");
            }
        }

        private void Insertar(TarjetaDebito tarjetaUsuario)
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();

                string query = "INSERT INTO tarjetasbananas (Titular, UsuarioOperario, NumeroTarjeta, cvv, FechaVencimiento, Saldo) " +
                               "VALUES (@Titular, @UsuarioOperario, @NumeroTarjeta, @cvv, @FechaVencimiento, @Saldo)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Titular", tarjetaUsuario.Titular);
                    cmd.Parameters.AddWithValue("@UsuarioOperario", tarjetaUsuario.UsuarioOperario);
                    cmd.Parameters.AddWithValue("@numeroTarjeta", tarjetaUsuario.NumeroTarjeta);
                    cmd.Parameters.AddWithValue("@cvv", tarjetaUsuario.CodigoSeguridad);
                    cmd.Parameters.AddWithValue("@Fechavencimiento", tarjetaUsuario.FechaVencimiento);
                    cmd.Parameters.AddWithValue("@Saldo", tarjetaUsuario.Saldo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos en la base de datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                MessageBox.Show("Se logro la conexion junto a la actualizacion de datos, procede a cerrarse ...");
            }
        }

        public void ActualizarBaseDeDatosDesdeJson()
        {
            MySqlConnection conexion = null;

            try
            {
                InsertUserJsonSql insertarDatos = new InsertUserJsonSql();
                insertarDatos.InsertarDataJson();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
                MessageBox.Show("Se termino la conexion");
            }
        }

        public void ActualizarBaseDeDatosDesdeXml()
        {
            MySqlConnection conexion = null;

            try
            {
                InsertUserJsonSql insertarDatos = new InsertUserJsonSql();
                insertarDatos.InsertarDataXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
                MessageBox.Show("Se termino la conexion y se han actualizado los datos.");
            }
        }

        public void ActualizarBaseDeDatosDesdeSql(DataGridView dataGridView)
        {
            try
            {
                // Realizar la consulta a la base de datos y obtener los datos
                List<Accion> acciones = ObtenerAccionesDesdeBaseDeDatos(conexion);

                // Actualizar el DataGridView con los datos obtenidos
                dataGridView.DataSource = acciones;

                MessageBox.Show("Datos actualizados desde la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }

        private List<Accion> ObtenerAccionesDesdeBaseDeDatos(MySqlConnection conexion)
        {
            List<Accion> acciones = new List<Accion>();

            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();

                string query = "SELECT * FROM accionesbananas";

                using (MySqlCommand command = new MySqlCommand(query, conexion))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Accion accion = new Accion(
                                reader["NombreAccion"].ToString(),
                                Convert.ToDecimal(reader["PrecioAlta"]),
                                Convert.ToDecimal(reader["PrecioBaja"]),
                                Convert.ToInt32(reader["Cantidad"])
                            );

                            acciones.Add(accion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener acciones desde la base de datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return acciones;
        }

        public User ObtenerUsuarioPorUsername(string username)
        {
            string usuarioOperario = frmIngresoCreacion.actualUsuario;
            ConexionDataBaseSql conexionSql = new ConexionDataBaseSql();
            conexionSql.EstableceConexionTest();

            // Aquí obtén la conexión utilizando el mismo método que usas en otras partes de tu código
            using (MySqlConnection conexion = conexionSql.EstableceConexionTest())
            {
                try
                {
                    conexion.Open();

                    // Utilizando parámetros en la consulta SQL
                    string query = $"SELECT * FROM usuariobananas WHERE Username = {usuarioOperario}";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Username", usuarioOperario);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User usuario = new User
                                {
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Rol = reader["Rol"].ToString(),
                                    FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
                                    Username = reader["Username"].ToString(),
                                    Contraseña = reader["Contraseña"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    DNI = reader["DNI"].ToString(),
                                    Cuit_Cuil = reader["Cuit_Cuil"].ToString(),
                                    Celular = reader["Celular"].ToString(),
                                    Domicilio = reader["Domicilio"].ToString(),
                                    CantidadAcciones = Convert.ToInt32(reader["CantidadAcciones"]),
                                    Saldo = Convert.ToDecimal(reader["Saldo"])
                                };

                                return usuario;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener usuario desde la base de datos: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }

            return null;
        }





        //METODO VERIFICACION//

        private bool UsuarioExiste(string username)
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();

                string query = "SELECT COUNT(*) FROM usuariobananas WHERE Username = @Username";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la existencia del usuario: " + ex.Message);
                return false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private bool TarjetaExiste(string username)
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();

                string query = "SELECT COUNT(*) FROM tarjetasbananas WHERE UsuarioOperario = @Username";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la existencia del usuario en tarjetas de débito: " + ex.Message);
                return false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

    }
}
