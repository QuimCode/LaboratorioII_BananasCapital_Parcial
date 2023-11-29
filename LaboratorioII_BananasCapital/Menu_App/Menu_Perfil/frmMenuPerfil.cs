using LaboratorioII_BananasCapital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_Formularios
{
    public partial class frmMenuPerfil : Form
    {
        string usuarioOperario = frmIngresoCreacion.actualUsuario;

        public frmMenuPerfil()
        {
            InitializeComponent();
            SQL_DataBase.InsertUserJsonSql selectData = new SQL_DataBase.InsertUserJsonSql();
            selectData.ObtenerUsuarioPorUsername(usuarioOperario);

            txtMostrarNombre =
            txtMostrarApellido = 
        }
    }
}
