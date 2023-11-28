using System.Data;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using BibliotecaClases.Usuarios_Tarjetas;
using BibliotecaClases.SQL_DataBase;

namespace BC_Formularios.SQL_DataBase
{
    internal class InsertUserJsonSql
    {
        private MySqlConnection conexion;

        public InsertUserJsonSql()
        {
            ConexionDataBaseSql conexionSql = new ConexionDataBaseSql();
            this.conexion = conexionSql.EstableceConexionTest();
        }

        public void InsertarJson()
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

        public void ActualizarBaseDeDatosDesdeJson()
        {
            MySqlConnection conexion = null;

            try
            {
                InsertUserJsonSql insertarDatos = new InsertUserJsonSql();
                insertarDatos.InsertarJson();
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

    }
}
