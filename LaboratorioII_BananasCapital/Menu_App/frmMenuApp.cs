using BC_Formularios.Menu_App;
using BC_Formularios.Menu_App.Menu_Administrativo;
using BC_Formularios.Menu_App.Menu_Mercado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases.SQL_DataBase;
using BC_Formularios.SQL_DataBase;

namespace BC_Formularios
{
    public partial class frmMenuApp : Form
    {
        public frmMenuApp()
        {
            InitializeComponent();
        }

        private void verCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPerfil perfil = new frmMenuPerfil();
            //Perfil.MdiParent = this;
            perfil.Show();
        }

        private void registrarTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCartera cartera = new frmCartera();
            cartera.Show();
        }

        private void depositarDineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeposito deposito = new frmDeposito();
            deposito.Show();
        }

        private void retirarDineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtraccion extraccion = new frmExtraccion();
            extraccion.Show();
        }

        private void accionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcciones acciones = new frmAcciones();
            acciones.Show();
        }

        private void eliminarCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminCuenta adminCuent = new frmAdminCuenta();
            adminCuent.Show();
        }

        private void testSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de la clase que maneja la actualización de la base de datos desde JSON
                InsertUserJsonSql insertarDatos = new InsertUserJsonSql();

                // Llamar al método que realiza la actualización
                insertarDatos.ActualizarBaseDeDatosDesdeJson();

                // Mostrar un mensaje indicando que la conexión se ha logrado
                MessageBox.Show("Se logró la conexión y se actualizó la base de datos desde JSON.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }


    }
}
