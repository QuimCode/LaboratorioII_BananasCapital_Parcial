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
        public void mostrarAlumnos(DataGridView gridInforme)
        {
            try
            {
                ConexionDataBaseSql conector = new ConexionDataBaseSql();
                conector.EstableceConexionTest();

                string consulta = "select * from alumnos";
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
    }
}
