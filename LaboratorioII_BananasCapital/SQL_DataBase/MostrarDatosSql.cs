using BibliotecaClases.SQL_DataBase;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BC_Formularios.SQL_DataBase
{
    public class MostrarDatosSql
    {

        /// <summary>
        /// Conecta la base de datos y aplica un argumento para el parametro del nombre de tabla, para especificar que tabla utilizar de la base de datos.
        /// Luego se aplica y muestra en el datagrid.
        /// </summary>
        /// <param name="gridInforme"></param>
        /// <param name="nombreTabla"></param>
        public void MostrarDatos(DataGridView gridInforme, string nombreTabla) //Implementando una referencia 'generica' para la seleccion de la tabla
        {
            try
            {
                ConexionDataBaseSql conector = new ConexionDataBaseSql();

                string consulta = $"SELECT * FROM {nombreTabla}";
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

        /// <summary>
        /// Captura de datos de la Base de Datos a los TextBox para su futura modificacion.
        /// </summary>
        /// <param name="gridUsuarios"></param>
        /// <param name="id"></param>
        /// <param name="dni"></param>
        /// <param name="cuit_cuil"></param>
        /// <param name="celular"></param>
        /// <param name="domicilio"></param>
        /// <param name="username"></param>
        /// <param name="contraseña"></param>
        /// <param name="email"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public void CapturarDatos(DataGridView gridUsuarios,TextBox id, TextBox dni, TextBox cuit_cuil, TextBox celular, TextBox domicilio,
            TextBox username, TextBox contraseña, TextBox email, TextBox nombre, TextBox apellido)
        {
            try
            {
                id.Text = gridUsuarios.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = gridUsuarios.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = gridUsuarios.CurrentRow.Cells[2].Value.ToString();
                username.Text = gridUsuarios.CurrentRow.Cells[5].Value.ToString();
                contraseña.Text = gridUsuarios.CurrentRow.Cells[6].Value.ToString();
                email.Text = gridUsuarios.CurrentRow.Cells[7].Value.ToString();
                dni.Text = gridUsuarios.CurrentRow.Cells[8].Value.ToString();
                cuit_cuil.Text = gridUsuarios.CurrentRow.Cells[9].Value.ToString();
                celular.Text = gridUsuarios.CurrentRow.Cells[10].Value.ToString();
                domicilio.Text = gridUsuarios.CurrentRow.Cells[11].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro guardar los datos de la Base de Datos" + e.ToString);
            }
        }

        /// <summary>
        /// Sobrecarga de capturar datos con una firma con menos parametros.
        /// </summary>
        /// <param name="gridUsuarios"></param>
        /// <param name="id"></param>
        /// <param name="codigo"></param>
        /// <param name="numeroTar"></param>
        /// <param name="saldo"></param>
        /// <param name="titular"></param>
        /// <param name="usernameOperario"></param>
        public void CapturarDatos(DataGridView gridUsuarios, TextBox id, TextBox codigo, TextBox numeroTar, TextBox titular, TextBox usernameOperario, TextBox saldo)
        {
            try
            {
                id.Text = gridUsuarios.CurrentRow.Cells[0].Value.ToString();
                codigo.Text = gridUsuarios.CurrentRow.Cells[1].Value.ToString();
                numeroTar.Text = gridUsuarios.CurrentRow.Cells[2].Value.ToString();
                titular.Text = gridUsuarios.CurrentRow.Cells[3].Value.ToString();
                usernameOperario.Text = gridUsuarios.CurrentRow.Cells[4].Value.ToString();                
                saldo.Text = gridUsuarios.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro guardar los datos de la Base de Datos" + e.ToString);
            }
        }

        public void CapturarUsuarios(DataGridView gridUsuarios, TextBox id)
        {
            try
            {
                id.Text = gridUsuarios.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro guardar los datos de la Base de Datos" + e.ToString);
            }
        }
        /// <summary>
        /// Metodo que toma las modificaciones de los TextBox por parametros y las utiliza como argumento para aplicar las modificaciones con un UPDATE en la tabla
        /// deseada utilizando el ID como numero unico del grid seleccionado, se aplica tambien 'genericos' con el nombre de la tabla para poder selecionar que 
        /// tabla de que DB utilizar.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dni"></param>
        /// <param name="cuit_cuil"></param>
        /// <param name="celular"></param>
        /// <param name="domicilio"></param>
        /// <param name="username"></param>
        /// <param name="contraseña"></param>
        /// <param name="email"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public void ModificarDatos(string nombreTabla, TextBox id, TextBox dni, TextBox cuit_cuil, TextBox celular, TextBox domicilio,
            TextBox username, TextBox contraseña, TextBox email, TextBox nombre, TextBox apellido)
        {
            try
            {
                ConexionDataBaseSql conector = new ConexionDataBaseSql();

                string consulta = "UPDATE usuariobananas SET cuit_cuil=@cuit_cuil, celular=@celular, domicilio=@domicilio, " +
                    "username=@username, contraseña=@contraseña, email=@email, nombre=@nombre, apellido=@apellido WHERE id = @id;";

                MySqlCommand comando = new MySqlCommand(consulta, conector.EstableceConexionTest());

                comando.Parameters.AddWithValue("@id", id.Text);
                comando.Parameters.AddWithValue("@cuit_cuil", cuit_cuil.Text);
                comando.Parameters.AddWithValue("@celular", celular.Text);
                comando.Parameters.AddWithValue("@domicilio", domicilio.Text);
                comando.Parameters.AddWithValue("@username", username.Text);
                comando.Parameters.AddWithValue("@contraseña", contraseña.Text);
                comando.Parameters.AddWithValue("@email", email.Text);
                comando.Parameters.AddWithValue("@nombre", nombre.Text);
                comando.Parameters.AddWithValue("@apellido", apellido.Text);

                int filasAfectadas = comando.ExecuteNonQuery();

                MessageBox.Show("Se modificaron los usuarios correctamente en el registro");

                conector.CerrarConexionTest();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se lograron modificar los datos de la Base de Datos" + e.ToString);
            }
        }

        public void ModificarDAtos(string nombreTabla, TextBox id, TextBox titular, TextBox usernameOperario, TextBox numeroTar, TextBox codigo, TextBox saldo )
        {
            try
            {
                ConexionDataBaseSql conector = new ConexionDataBaseSql();

                string consulta = $"UPDATE {nombreTabla} SET titular=@titular, usuariooperario=@usuariooperario, numerotarjeta=@numerotarjeta, " +
                    "cvv=@cvv, saldo=@saldo WHERE id = @id;";

                MySqlCommand comando = new MySqlCommand(consulta, conector.EstableceConexionTest());

                comando.Parameters.AddWithValue("@id", id.Text);
                comando.Parameters.AddWithValue("@titular", titular.Text);
                comando.Parameters.AddWithValue("@usuariooperario", usernameOperario.Text);
                comando.Parameters.AddWithValue("@numerotarjeta", numeroTar.Text);
                comando.Parameters.AddWithValue("@cvv", codigo.Text);
                comando.Parameters.AddWithValue("@saldo", saldo.Text);

                int filasAfectadas = comando.ExecuteNonQuery();

                MessageBox.Show("Se modificaron las tarjetas correctamente en el registro");

                conector.CerrarConexionTest();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se lograron modificar los datos de la Base de Datos" + e.ToString);
            }
        }

        public void EliminarDatos(TextBox id, string nombreTabla)
        {
            try
            {
                ConexionDataBaseSql conector = new ConexionDataBaseSql();

                string consulta = $"DELETE FROM {nombreTabla} WHERE id = @id;";

                MySqlCommand comando = new MySqlCommand(consulta, conector.EstableceConexionTest());
                comando.Parameters.AddWithValue("@id", id.Text);

                int filasAfectadas = comando.ExecuteNonQuery();

                MessageBox.Show("Se elimino los usuarios correctamente en el registro");

                conector.CerrarConexionTest();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro eliminar la tarjeta." + e.ToString);
            }
        }


    }
}



//public void guardarUsuarios(TextBox dni, TextBox cuit_cuil, TextBox celular, TextBox domicilio,
//    TextBox username, TextBox contraseña, TextBox email, TextBox nombre, TextBox apellido)
//{
//    try
//    {
//        ConexionDataBaseSql conector = new ConexionDataBaseSql();

//        string consulta = "insert into usuarios (dni, cuit_cuil, celular, domicilio, username, contraseña, email, nombre, apellido)" +
//        "values ('" + dni.Text + "', '" + cuit_cuil.Text + "', '" + celular.Text + "', '" + domicilio.Text + "','" + username.Text + "', '" + contraseña.Text + "', '" + email.Text + "', '" + nombre.Text + "', '" + apellido.Text + "');";

//        MySqlCommand comando = new MySqlCommand(consulta, conector.EstableceConexionTest());
//        MySqlDataReader lector = comando.ExecuteReader();
//        MessageBox.Show("Se guardaron correctamente en el registro");

//        while (lector.Read()) 
//        {
//        }

//        conector.CerrarConexionTest();
//    }
//    catch (Exception e)
//    {
//        MessageBox.Show("No se logro guardar los datos de la Base de Datos" + e.ToString);
//    }
//}