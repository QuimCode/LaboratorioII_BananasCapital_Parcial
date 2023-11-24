using BibliotecaClases.SQL_DataBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Formularios.SQL_DataBase
{
    public class MostrarDatosSql
    {
        public void mostrarUsuarios(DataGridView gridInforme)
        {
            try
            {
                ConexionDataBaseSql conector = new ConexionDataBaseSql();
                //conector.EstableceConexionTest();

                string consulta = "select * from usuarios";
                gridInforme.DataSource = null;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conector.EstableceConexionTest());
                DataTable tablaDatos = new DataTable();
                adaptador.Fill(tablaDatos);
                gridInforme.DataSource = tablaDatos;
                conector.CerrarConexionTest();
            }
            catch(Exception e) 
            {
                MessageBox.Show("No se logro cargar los datos de la Base de Datos" + e.ToString);
            }
        }



        public void guardarUsuarios(TextBox dni, TextBox cuit_cuil, TextBox celular, TextBox domicilio,
            TextBox username, TextBox contraseña, TextBox email, TextBox nombre, TextBox apellido)
        {
            try
            {
                ConexionDataBaseSql conector = new ConexionDataBaseSql();

                string consulta = "insert into usuarios (dni, cuit_cuil, celular, domicilio, username, contraseña, email, nombre, apellido)" +
                "values ('" + dni.Text + "', '" + cuit_cuil.Text + "', '" + celular.Text + "', '" + domicilio.Text + "','" + username.Text + "', '" + contraseña.Text + "', '" + email.Text + "', '" + nombre.Text + "', '" + apellido.Text + "');";

                MySqlCommand comando = new MySqlCommand(consulta, conector.EstableceConexionTest());
                MySqlDataReader lector = comando.ExecuteReader();
                MessageBox.Show("Se guardaron correctamente en el registro");

                while (lector.Read()) 
                {
                }

                conector.CerrarConexionTest();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro guardar los datos de la Base de Datos" + e.ToString);
            }
        }

        public void CapturarUsuarios(DataGridView gridUsuarios, TextBox dni, TextBox cuit_cuil, TextBox celular, TextBox domicilio,
            TextBox username, TextBox contraseña, TextBox email, TextBox nombre, TextBox apellido)
        {
            try
            {
                dni.Text = gridUsuarios.CurrentRow.Cells[0].Value.ToString();
                cuit_cuil.Text = gridUsuarios.CurrentRow.Cells[1].Value.ToString();
                celular.Text = gridUsuarios.CurrentRow.Cells[2].Value.ToString();
                domicilio.Text = gridUsuarios.CurrentRow.Cells[3].Value.ToString();
                username.Text = gridUsuarios.CurrentRow.Cells[4].Value.ToString();
                contraseña.Text = gridUsuarios.CurrentRow.Cells[5].Value.ToString();
                email.Text = gridUsuarios.CurrentRow.Cells[6].Value.ToString();
                nombre.Text = gridUsuarios.CurrentRow.Cells[9].Value.ToString();
                apellido.Text = gridUsuarios.CurrentRow.Cells[10].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro guardar los datos de la Base de Datos" + e.ToString);
            }
        }

        public void CapturarUsuarios(DataGridView gridUsuarios, TextBox dni)
        {
            try
            {
                dni.Text = gridUsuarios.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro guardar los datos de la Base de Datos" + e.ToString);
            }
        }

        public void ModificarUsuarios(TextBox dni, TextBox cuit_cuil, TextBox celular, TextBox domicilio,
            TextBox username, TextBox contraseña, TextBox email, TextBox nombre, TextBox apellido)
        {
            try
            {
                ConexionDataBaseSql conector = new ConexionDataBaseSql();

                string consulta = "UPDATE usuarios SET cuit_cuil=@cuit_cuil, celular=@celular, domicilio=@domicilio, username=@username, contraseña=@contraseña, email=@email, nombre=@nombre, apellido=@apellido WHERE dni = @dni;";

                MySqlCommand comando = new MySqlCommand(consulta, conector.EstableceConexionTest());

                comando.Parameters.AddWithValue("@cuit_cuil", cuit_cuil.Text);
                comando.Parameters.AddWithValue("@celular", celular.Text);
                comando.Parameters.AddWithValue("@domicilio", domicilio.Text);
                comando.Parameters.AddWithValue("@username", username.Text);
                comando.Parameters.AddWithValue("@contraseña", contraseña.Text);
                comando.Parameters.AddWithValue("@email", email.Text);
                comando.Parameters.AddWithValue("@nombre", nombre.Text);
                comando.Parameters.AddWithValue("@apellido", apellido.Text);
                comando.Parameters.AddWithValue("@dni", dni.Text);

                int filasAfectadas = comando.ExecuteNonQuery();

                //MySqlDataReader lector = comando.ExecuteReader();
                MessageBox.Show("Se modificaron los usuarios correctamente en el registro");

                //while (lector.Read())
                //{
                //}

                conector.CerrarConexionTest();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se lograron modificar los datos de la Base de Datos" + e.ToString);
            }
        }

        public void EliminarUsuarios(TextBox dni)
        {
            try
            {
                ConexionDataBaseSql conector = new ConexionDataBaseSql();

                string consulta = "delete from usuarios where dni = @dni;";

                MySqlCommand comando = new MySqlCommand(consulta, conector.EstableceConexionTest());
                comando.Parameters.AddWithValue("@dni", dni.Text);

                int filasAfectadas = comando.ExecuteNonQuery();

                //MySqlDataReader lector = comando.ExecuteReader();
                MessageBox.Show("Se elimino los usuarios correctamente en el registro");

                //while (lector.Read())
                //{
                //}

                conector.CerrarConexionTest();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro eliminar al usuario." + e.ToString);
            }
        }
    }
}
