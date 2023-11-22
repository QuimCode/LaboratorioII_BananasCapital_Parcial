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
    }
}
