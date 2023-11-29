using LaboratorioII_BananasCapital;
using static BibliotecaClases.Usuarios_Tarjetas.ClassUsuarios;
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
            //SQL_DataBase.InsertUserJsonSql selectData = new SQL_DataBase.InsertUserJsonSql();
            //selectData.ObtenerUsuarioPorUsername(usuarioOperario);

            SQL_DataBase.InsertUserJsonSql selectData = new SQL_DataBase.InsertUserJsonSql();
            User usuario = selectData.ObtenerUsuarioPorUsername(usuarioOperario);

            if (usuario != null)
            {
                txtMostrarNombre.Text = usuario.Nombre;
                txtMostrarApellido.Text = usuario.Apellido;
                txtMostrarNombreUsuario.Text = usuario.Username;
                txtMostrarCorreo.Text = usuario.Email;
                txtMostrarDNI.Text = usuario.DNI;
                txtMostrarCUIL.Text = usuario.Cuit_Cuil;
                txtMostrarTelefono.Text = usuario.Celular;
                txtMostrarResidencia.Text = usuario.Domicilio;

                MessageBox.Show("Información del usuario cargada exitosamente.");
            }
            else
            {
                MessageBox.Show("No se pudo obtener la información del usuario.");
            }
        }
    }
}
