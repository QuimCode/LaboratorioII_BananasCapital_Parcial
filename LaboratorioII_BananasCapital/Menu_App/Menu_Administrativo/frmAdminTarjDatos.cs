using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_Formularios.Menu_App.Menu_Administrativo
{
    public partial class frmAdminTarjDatos : Form
    {
        string tablaDB = "tarjetasbananas";

        public frmAdminTarjDatos()
        {
            InitializeComponent();

            SQL_DataBase.InsertUserJsonSql cargarInformacionTarjetas = new SQL_DataBase.InsertUserJsonSql();
            cargarInformacionTarjetas.ActualizarBaseDeDatosDesdeXml();
        }

        private void btnCargaTarjetas_Click(object sender, EventArgs e)
        {
            SQL_DataBase.MostrarDatosSql mostrarInfo = new SQL_DataBase.MostrarDatosSql();
            mostrarInfo.MostrarDatos(userDataGridView, tablaDB);
        }

        private void btnEliminarTarjetas_Click(object sender, EventArgs e)
        {
            SQL_DataBase.MostrarDatosSql eliminarInfo = new SQL_DataBase.MostrarDatosSql();
            eliminarInfo.ModificarDAtos(tablaDB, txtID, txtTitular, txtUsuario, txtNumeroTarjeta, txtSeguridad, txtSaldo);
            SQL_DataBase.MostrarDatosSql mostrarInfo = new SQL_DataBase.MostrarDatosSql();
            mostrarInfo.MostrarDatos(userDataGridView, tablaDB);
        }

        private void userDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SQL_DataBase.MostrarDatosSql capturarEliminacion = new SQL_DataBase.MostrarDatosSql();
            capturarEliminacion.CapturarDatos(userDataGridView, txtID, txtTitular, txtUsuario, txtNumeroTarjeta, txtSeguridad, txtSaldo);
        }
    }
}
