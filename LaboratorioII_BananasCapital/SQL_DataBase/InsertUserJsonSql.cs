using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.IO;
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

                    // Deserializar el JSON a una lista de ClassUsuarios.User
                    var listaUsuarios = JsonConvert.DeserializeObject<List<ClassUsuarios.User>>(json);

                    // Luego, puedes insertar los datos en la base de datos
                    foreach (var userData in listaUsuarios)
                    {
                        Insertar(userData);
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

                // Supongamos que tienes una tabla 'usuarios' en tu base de datos
                string query = "INSERT INTO usuarios (DNI, Cuit_Cuil, Celular, Domicilio, Username, Contraseña, Email, CantidadAcciones, FechaRegistro, Nombre, Apellido, Rol, Saldo) " +
                               "VALUES (@DNI, @Cuit_Cuil, @Celular, @Domicilio, @Username, @Contraseña, @Email, @CantidadAcciones, @FechaRegistro, @Nombre, @Apellido, @Rol, @Saldo)";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@DNI", userData.DNI);
                    cmd.Parameters.AddWithValue("@Cuit_Cuil", userData.Cuit_Cuil);
                    cmd.Parameters.AddWithValue("@Celular", userData.Celular);
                    cmd.Parameters.AddWithValue("@Domicilio", userData.Domicilio);
                    cmd.Parameters.AddWithValue("@Username", userData.Username);
                    cmd.Parameters.AddWithValue("@Contraseña", userData.Contraseña);
                    cmd.Parameters.AddWithValue("@Email", userData.Email);
                    cmd.Parameters.AddWithValue("@CantidadAcciones", userData.CantidadAcciones);
                    cmd.Parameters.AddWithValue("@FechaRegistro", userData.FechaRegistro);
                    cmd.Parameters.AddWithValue("@Nombre", userData.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", userData.Apellido);
                    cmd.Parameters.AddWithValue("@Rol", userData.Rol);
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
            }
        }

        public void ActualizarBaseDeDatosDesdeJson()
        {
            MySqlConnection conexion = null;

            try
            {
                // Crear una instancia de la clase de conexión y establecer la conexión
                //ConexionDataBaseSql conexionSql = new ConexionDataBaseSql();
                //conexion = conexionSql.EstableceConexionTest();

                // Crear una instancia de la clase que inserta datos y pasar la conexión
                InsertUserJsonSql insertarDatos = new InsertUserJsonSql();

                // Llamar al método que inserta datos desde el JSON a la base de datos
                insertarDatos.InsertarJson();

                MessageBox.Show("Se logro la conexion");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión después de usarla
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

    }
}
