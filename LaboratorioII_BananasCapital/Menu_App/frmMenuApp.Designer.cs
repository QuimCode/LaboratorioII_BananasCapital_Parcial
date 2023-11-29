namespace BC_Formularios
{
    partial class frmMenuApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuApp));
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            mnMenu = new MenuStrip();
            tuPerfilToolStripMenuItem = new ToolStripMenuItem();
            verCuentaToolStripMenuItem = new ToolStripMenuItem();
            eliminarCuentaToolStripMenuItem = new ToolStripMenuItem();
            carteraCuentaToolStripMenuItem = new ToolStripMenuItem();
            tarjetaToolStripMenuItem = new ToolStripMenuItem();
            registrarTarjetaToolStripMenuItem = new ToolStripMenuItem();
            eliminarTarjetaToolStripMenuItem = new ToolStripMenuItem();
            depositarDineroToolStripMenuItem = new ToolStripMenuItem();
            retirarDineroToolStripMenuItem = new ToolStripMenuItem();
            mercadoToolStripMenuItem = new ToolStripMenuItem();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            dolarMEPToolStripMenuItem = new ToolStripMenuItem();
            administracionToolStripMenuItem = new ToolStripMenuItem();
            eliminarCuentasToolStripMenuItem = new ToolStripMenuItem();
            modificarCuentasToolStripMenuItem = new ToolStripMenuItem();
            eliminarTarjetasToolStripMenuItem = new ToolStripMenuItem();
            modificarTarjetasToolStripMenuItem = new ToolStripMenuItem();
            testSQLToolStripMenuItem = new ToolStripMenuItem();
            sqlAccionesToolStripMenuItem = new ToolStripMenuItem();
            sqlUsuariosToolStripMenuItem = new ToolStripMenuItem();
            sqlTarjetasToolStripMenuItem = new ToolStripMenuItem();
            testNuggetToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            mnMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 55, 95);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(mnMenu);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1132, 741);
            panel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Khaki;
            richTextBox1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.Location = new Point(98, 188);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(937, 365);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // mnMenu
            // 
            mnMenu.BackColor = Color.Khaki;
            mnMenu.Items.AddRange(new ToolStripItem[] { tuPerfilToolStripMenuItem, carteraCuentaToolStripMenuItem, mercadoToolStripMenuItem, administracionToolStripMenuItem, testSQLToolStripMenuItem, testNuggetToolStripMenuItem });
            mnMenu.Location = new Point(0, 0);
            mnMenu.Name = "mnMenu";
            mnMenu.Size = new Size(1132, 24);
            mnMenu.TabIndex = 0;
            mnMenu.Text = "menuStrip1";
            // 
            // tuPerfilToolStripMenuItem
            // 
            tuPerfilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verCuentaToolStripMenuItem, eliminarCuentaToolStripMenuItem });
            tuPerfilToolStripMenuItem.Name = "tuPerfilToolStripMenuItem";
            tuPerfilToolStripMenuItem.Size = new Size(57, 20);
            tuPerfilToolStripMenuItem.Text = "Cuenta";
            // 
            // verCuentaToolStripMenuItem
            // 
            verCuentaToolStripMenuItem.Name = "verCuentaToolStripMenuItem";
            verCuentaToolStripMenuItem.Size = new Size(158, 22);
            verCuentaToolStripMenuItem.Text = "Ver Cuenta";
            verCuentaToolStripMenuItem.Click += verCuentaToolStripMenuItem_Click;
            // 
            // eliminarCuentaToolStripMenuItem
            // 
            eliminarCuentaToolStripMenuItem.Name = "eliminarCuentaToolStripMenuItem";
            eliminarCuentaToolStripMenuItem.Size = new Size(158, 22);
            eliminarCuentaToolStripMenuItem.Text = "Eliminar Cuenta";
            // 
            // carteraCuentaToolStripMenuItem
            // 
            carteraCuentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tarjetaToolStripMenuItem, depositarDineroToolStripMenuItem, retirarDineroToolStripMenuItem });
            carteraCuentaToolStripMenuItem.Name = "carteraCuentaToolStripMenuItem";
            carteraCuentaToolStripMenuItem.Size = new Size(98, 20);
            carteraCuentaToolStripMenuItem.Text = "Cartera Cuenta";
            // 
            // tarjetaToolStripMenuItem
            // 
            tarjetaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarTarjetaToolStripMenuItem, eliminarTarjetaToolStripMenuItem });
            tarjetaToolStripMenuItem.Name = "tarjetaToolStripMenuItem";
            tarjetaToolStripMenuItem.Size = new Size(162, 22);
            tarjetaToolStripMenuItem.Text = "Tarjeta";
            // 
            // registrarTarjetaToolStripMenuItem
            // 
            registrarTarjetaToolStripMenuItem.Name = "registrarTarjetaToolStripMenuItem";
            registrarTarjetaToolStripMenuItem.Size = new Size(157, 22);
            registrarTarjetaToolStripMenuItem.Text = "Registrar Tarjeta";
            registrarTarjetaToolStripMenuItem.Click += registrarTarjetaToolStripMenuItem_Click;
            // 
            // eliminarTarjetaToolStripMenuItem
            // 
            eliminarTarjetaToolStripMenuItem.Name = "eliminarTarjetaToolStripMenuItem";
            eliminarTarjetaToolStripMenuItem.Size = new Size(157, 22);
            eliminarTarjetaToolStripMenuItem.Text = "Eliminar Tarjeta";
            // 
            // depositarDineroToolStripMenuItem
            // 
            depositarDineroToolStripMenuItem.Name = "depositarDineroToolStripMenuItem";
            depositarDineroToolStripMenuItem.Size = new Size(162, 22);
            depositarDineroToolStripMenuItem.Text = "Depositar Dinero";
            depositarDineroToolStripMenuItem.Click += depositarDineroToolStripMenuItem_Click;
            // 
            // retirarDineroToolStripMenuItem
            // 
            retirarDineroToolStripMenuItem.Name = "retirarDineroToolStripMenuItem";
            retirarDineroToolStripMenuItem.Size = new Size(162, 22);
            retirarDineroToolStripMenuItem.Text = "Retirar Dinero";
            retirarDineroToolStripMenuItem.Click += retirarDineroToolStripMenuItem_Click;
            // 
            // mercadoToolStripMenuItem
            // 
            mercadoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accionesToolStripMenuItem, dolarMEPToolStripMenuItem });
            mercadoToolStripMenuItem.Name = "mercadoToolStripMenuItem";
            mercadoToolStripMenuItem.Size = new Size(66, 20);
            mercadoToolStripMenuItem.Text = "Mercado";
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(129, 22);
            accionesToolStripMenuItem.Text = "Acciones";
            accionesToolStripMenuItem.Click += accionesToolStripMenuItem_Click;
            // 
            // dolarMEPToolStripMenuItem
            // 
            dolarMEPToolStripMenuItem.Name = "dolarMEPToolStripMenuItem";
            dolarMEPToolStripMenuItem.Size = new Size(129, 22);
            dolarMEPToolStripMenuItem.Text = "Dolar MEP";
            // 
            // administracionToolStripMenuItem
            // 
            administracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eliminarCuentasToolStripMenuItem, modificarCuentasToolStripMenuItem, eliminarTarjetasToolStripMenuItem, modificarTarjetasToolStripMenuItem });
            administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            administracionToolStripMenuItem.Size = new Size(100, 20);
            administracionToolStripMenuItem.Text = "Administracion";
            // 
            // eliminarCuentasToolStripMenuItem
            // 
            eliminarCuentasToolStripMenuItem.Name = "eliminarCuentasToolStripMenuItem";
            eliminarCuentasToolStripMenuItem.Size = new Size(171, 22);
            eliminarCuentasToolStripMenuItem.Text = "Eliminar Cuentas";
            eliminarCuentasToolStripMenuItem.Click += eliminarCuentasToolStripMenuItem_Click;
            // 
            // modificarCuentasToolStripMenuItem
            // 
            modificarCuentasToolStripMenuItem.Name = "modificarCuentasToolStripMenuItem";
            modificarCuentasToolStripMenuItem.Size = new Size(171, 22);
            modificarCuentasToolStripMenuItem.Text = "Modificar Cuentas";
            modificarCuentasToolStripMenuItem.Click += modificarCuentasToolStripMenuItem_Click;
            // 
            // eliminarTarjetasToolStripMenuItem
            // 
            eliminarTarjetasToolStripMenuItem.Name = "eliminarTarjetasToolStripMenuItem";
            eliminarTarjetasToolStripMenuItem.Size = new Size(171, 22);
            eliminarTarjetasToolStripMenuItem.Text = "Eliminar Tarjetas";
            eliminarTarjetasToolStripMenuItem.Click += eliminarTarjetasToolStripMenuItem_Click;
            // 
            // modificarTarjetasToolStripMenuItem
            // 
            modificarTarjetasToolStripMenuItem.Name = "modificarTarjetasToolStripMenuItem";
            modificarTarjetasToolStripMenuItem.Size = new Size(171, 22);
            modificarTarjetasToolStripMenuItem.Text = "Modificar Tarjetas";
            modificarTarjetasToolStripMenuItem.Click += modificarTarjetasToolStripMenuItem_Click;
            // 
            // testSQLToolStripMenuItem
            // 
            testSQLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sqlAccionesToolStripMenuItem, sqlUsuariosToolStripMenuItem, sqlTarjetasToolStripMenuItem });
            testSQLToolStripMenuItem.Name = "testSQLToolStripMenuItem";
            testSQLToolStripMenuItem.Size = new Size(99, 20);
            testSQLToolStripMenuItem.Text = "Carga de Datos";
            // 
            // sqlAccionesToolStripMenuItem
            // 
            sqlAccionesToolStripMenuItem.Name = "sqlAccionesToolStripMenuItem";
            sqlAccionesToolStripMenuItem.Size = new Size(180, 22);
            sqlAccionesToolStripMenuItem.Text = "SqlAcciones";
            sqlAccionesToolStripMenuItem.Click += sqlAccionesToolStripMenuItem_Click;
            // 
            // sqlUsuariosToolStripMenuItem
            // 
            sqlUsuariosToolStripMenuItem.Name = "sqlUsuariosToolStripMenuItem";
            sqlUsuariosToolStripMenuItem.Size = new Size(180, 22);
            sqlUsuariosToolStripMenuItem.Text = "SqlUsuarios";
            sqlUsuariosToolStripMenuItem.Click += sqlUsuariosToolStripMenuItem_Click;
            // 
            // sqlTarjetasToolStripMenuItem
            // 
            sqlTarjetasToolStripMenuItem.Name = "sqlTarjetasToolStripMenuItem";
            sqlTarjetasToolStripMenuItem.Size = new Size(180, 22);
            sqlTarjetasToolStripMenuItem.Text = "SqlTarjetas";
            sqlTarjetasToolStripMenuItem.Click += sqlTarjetasToolStripMenuItem_Click;
            // 
            // testNuggetToolStripMenuItem
            // 
            testNuggetToolStripMenuItem.Name = "testNuggetToolStripMenuItem";
            testNuggetToolStripMenuItem.Size = new Size(79, 20);
            testNuggetToolStripMenuItem.Text = "TestNugget";
            // 
            // frmMenuApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 741);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MainMenuStrip = mnMenu;
            Name = "frmMenuApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Bananas Capital";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mnMenu.ResumeLayout(false);
            mnMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip mnMenu;
        private ToolStripMenuItem tuPerfilToolStripMenuItem;
        private ToolStripMenuItem verCuentaToolStripMenuItem;
        private ToolStripMenuItem eliminarCuentaToolStripMenuItem;
        private ToolStripMenuItem carteraCuentaToolStripMenuItem;
        private ToolStripMenuItem tarjetaToolStripMenuItem;
        private ToolStripMenuItem registrarTarjetaToolStripMenuItem;
        private ToolStripMenuItem eliminarTarjetaToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem depositarDineroToolStripMenuItem;
        private ToolStripMenuItem retirarDineroToolStripMenuItem;
        private ToolStripMenuItem mercadoToolStripMenuItem;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem dolarMEPToolStripMenuItem;
        private ToolStripMenuItem administracionToolStripMenuItem;
        private ToolStripMenuItem eliminarCuentasToolStripMenuItem;
        private ToolStripMenuItem modificarCuentasToolStripMenuItem;
        private ToolStripMenuItem testNuggetToolStripMenuItem;
        private ToolStripMenuItem testSQLToolStripMenuItem;
        private ToolStripMenuItem eliminarTarjetasToolStripMenuItem;
        private ToolStripMenuItem modificarTarjetasToolStripMenuItem;
        private ToolStripMenuItem sqlAccionesToolStripMenuItem;
        private ToolStripMenuItem sqlUsuariosToolStripMenuItem;
        private ToolStripMenuItem sqlTarjetasToolStripMenuItem;
    }
}