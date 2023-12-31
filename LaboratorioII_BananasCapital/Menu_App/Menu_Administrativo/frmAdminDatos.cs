﻿using System;
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
    public partial class frmAdminDatos : Form
    {
        public frmAdminDatos()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            string tablaDB = "usuariobananas";

            SQL_DataBase.MostrarDatosSql mostrarInfo = new SQL_DataBase.MostrarDatosSql();
            mostrarInfo.MostrarDatos(userDataGridView, tablaDB);
        }

        private void btnModificarUsuarios_Click(object sender, EventArgs e)
        {
            string tablaDB = "usuariobananas";

            SQL_DataBase.MostrarDatosSql modificarInfo = new SQL_DataBase.MostrarDatosSql();
            modificarInfo.ModificarDatos(tablaDB, txtId, txtMostrarDNI, txtMostrarCUIL, txtMostrarTelefono, txtMostrarResidencia,
                                            txtMostrarNombreUsuario, txtMostrarContraseña, txtMostrarCorreo, txtMostrarNombre, txtMostrarApellido);
        }

        private void userDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SQL_DataBase.MostrarDatosSql capturarInfo = new SQL_DataBase.MostrarDatosSql();
            capturarInfo.CapturarDatos(userDataGridView, txtId, txtMostrarDNI, txtMostrarCUIL, txtMostrarTelefono, txtMostrarResidencia,
                                            txtMostrarNombreUsuario, txtMostrarContraseña, txtMostrarCorreo, txtMostrarNombre, txtMostrarApellido);
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            string tablaDB = "usuariobananas";

            SQL_DataBase.MostrarDatosSql mostrarInfo = new SQL_DataBase.MostrarDatosSql();
            mostrarInfo.MostrarDatos(userDataGridView, tablaDB);
        }
    }
}
