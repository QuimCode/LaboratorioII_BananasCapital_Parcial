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
    public partial class frmAdminCuenta : Form
    {
        public frmAdminCuenta()
        {
            InitializeComponent();
        }

        private void btnCargaUsuarios_Click(object sender, EventArgs e)
        {
            SQL_DataBase.MostrarDatosSql mostrarInfo = new SQL_DataBase.MostrarDatosSql();
            mostrarInfo.mostrarUsuarios(userDataGridView);
        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            SQL_DataBase.MostrarDatosSql eliminar = new SQL_DataBase.MostrarDatosSql();
            eliminar.EliminarUsuarios(txtMostrarID);
            SQL_DataBase.MostrarDatosSql mostrarInfo = new SQL_DataBase.MostrarDatosSql();
            mostrarInfo.mostrarUsuarios(userDataGridView);
        }

        private void userDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SQL_DataBase.MostrarDatosSql capturarEliminacion = new SQL_DataBase.MostrarDatosSql();
            capturarEliminacion.CapturarUsuarios(userDataGridView, txtMostrarID);
        }
    }
}
