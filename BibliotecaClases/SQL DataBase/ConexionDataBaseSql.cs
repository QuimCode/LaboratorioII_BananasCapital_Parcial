//using System;
//using System.Windows;
//using System.Windows.Forms;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

//namespace BibliotecaClases.SQL_DataBase
//{
//    public class ConexionDataBaseSql
//    {
//        MySqlConnection ConexionBD = new MySqlConnection();

//        static string servidor = "localhost";
//        static string nombreBD = "usersbananas";
//        static string usuario = "root";
//        static string contraseña = "S1vw06vf";
//        static string puerto = "3306";

//        string conexionDeCadena = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "UserId=" + usuario + ";" + "Password=" + contraseña + ";" + "Database=" + nombreBD + ";";

//        public MySqlConnection EstableceConexionTest()
//        {
//            try
//            {
//                ConexionBD.ConnectionString = conexionDeCadena;
//                ConexionBD.Open();
//                MessageBox
//            }
//            catch (MySqlException ex)
//            {
//                MessageBox.Show("No se ha podido lograr la conexión. Excepción de tipo MySqlException: " + ex.Message);
//            }

//            return ConexionBD;
//        }
//    }
//}

//MySql.Data
//OoplesFinance.YahooFinanceAPI