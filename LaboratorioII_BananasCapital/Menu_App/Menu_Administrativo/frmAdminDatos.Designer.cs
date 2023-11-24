namespace BC_Formularios.Menu_App.Menu_Administrativo
{
    partial class frmAdminDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDatos));
            pnTitulo = new Panel();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            tittleB = new RichTextBox();
            richTextBox1 = new RichTextBox();
            userDataGridView = new DataGridView();
            pnIngreso = new Panel();
            btnCargarDatos = new Button();
            btnGuardarDatos = new Button();
            label1 = new Label();
            label4 = new Label();
            txtMostrarNombre = new TextBox();
            label8 = new Label();
            txtMostrarNombreUsuario = new TextBox();
            label6 = new Label();
            txtMostrarDNI = new TextBox();
            label5 = new Label();
            txtMostrarTelefono = new TextBox();
            btnModificarUsuarios = new Button();
            txtMostrarResidencia = new TextBox();
            richText = new RichTextBox();
            txtMostrarApellido = new TextBox();
            label7 = new Label();
            label2 = new Label();
            txtMostrarCUIL = new TextBox();
            txtMostrarCorreo = new TextBox();
            label3 = new Label();
            txtMostrarContraseña = new TextBox();
            label9 = new Label();
            pnTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            pnIngreso.SuspendLayout();
            SuspendLayout();
            // 
            // pnTitulo
            // 
            pnTitulo.BackColor = Color.FromArgb(39, 39, 70);
            pnTitulo.Controls.Add(richTextBox2);
            pnTitulo.Controls.Add(richTextBox3);
            pnTitulo.Controls.Add(tittleB);
            pnTitulo.Controls.Add(richTextBox1);
            pnTitulo.Location = new Point(0, 0);
            pnTitulo.Name = "pnTitulo";
            pnTitulo.Size = new Size(1126, 129);
            pnTitulo.TabIndex = 0;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(39, 39, 70);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox2.ForeColor = Color.Transparent;
            richTextBox2.Location = new Point(760, 22);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(311, 48);
            richTextBox2.TabIndex = 34;
            richTextBox2.Text = ".ADMINISTRACION";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(39, 39, 70);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox3.ForeColor = Color.Khaki;
            richTextBox3.Location = new Point(590, 22);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(175, 52);
            richTextBox3.TabIndex = 33;
            richTextBox3.Text = "BANANAS";
            // 
            // tittleB
            // 
            tittleB.BackColor = Color.FromArgb(39, 39, 70);
            tittleB.BorderStyle = BorderStyle.None;
            tittleB.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tittleB.ForeColor = Color.Transparent;
            tittleB.Location = new Point(219, 22);
            tittleB.Name = "tittleB";
            tittleB.Size = new Size(175, 48);
            tittleB.TabIndex = 32;
            tittleB.Text = ".CAPITAL";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(39, 39, 70);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.Khaki;
            richTextBox1.Location = new Point(49, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(175, 52);
            richTextBox1.TabIndex = 31;
            richTextBox1.Text = "BANANAS";
            // 
            // userDataGridView
            // 
            userDataGridView.BackgroundColor = Color.FromArgb(55, 55, 95);
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(-2, 124);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowTemplate.Height = 25;
            userDataGridView.Size = new Size(543, 619);
            userDataGridView.TabIndex = 3;
            userDataGridView.CellDoubleClick += userDataGridView_CellDoubleClick;
            // 
            // pnIngreso
            // 
            pnIngreso.BackColor = Color.FromArgb(52, 52, 80);
            pnIngreso.Controls.Add(label9);
            pnIngreso.Controls.Add(txtMostrarContraseña);
            pnIngreso.Controls.Add(btnCargarDatos);
            pnIngreso.Controls.Add(btnGuardarDatos);
            pnIngreso.Controls.Add(label1);
            pnIngreso.Controls.Add(label4);
            pnIngreso.Controls.Add(txtMostrarNombre);
            pnIngreso.Controls.Add(label8);
            pnIngreso.Controls.Add(txtMostrarNombreUsuario);
            pnIngreso.Controls.Add(label6);
            pnIngreso.Controls.Add(txtMostrarDNI);
            pnIngreso.Controls.Add(label5);
            pnIngreso.Controls.Add(txtMostrarTelefono);
            pnIngreso.Controls.Add(btnModificarUsuarios);
            pnIngreso.Controls.Add(txtMostrarResidencia);
            pnIngreso.Controls.Add(richText);
            pnIngreso.Controls.Add(pnTitulo);
            pnIngreso.Controls.Add(txtMostrarApellido);
            pnIngreso.Controls.Add(label7);
            pnIngreso.Controls.Add(label2);
            pnIngreso.Controls.Add(txtMostrarCUIL);
            pnIngreso.Controls.Add(txtMostrarCorreo);
            pnIngreso.Controls.Add(label3);
            pnIngreso.Location = new Point(-2, -2);
            pnIngreso.Name = "pnIngreso";
            pnIngreso.Size = new Size(1129, 741);
            pnIngreso.TabIndex = 4;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.FlatStyle = FlatStyle.Flat;
            btnCargarDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarDatos.ForeColor = SystemColors.ButtonFace;
            btnCargarDatos.Location = new Point(625, 349);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(115, 48);
            btnCargarDatos.TabIndex = 41;
            btnCargarDatos.Text = "Cargar Datos";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.FlatStyle = FlatStyle.Flat;
            btnGuardarDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarDatos.ForeColor = SystemColors.ButtonFace;
            btnGuardarDatos.Location = new Point(924, 349);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(115, 48);
            btnGuardarDatos.TabIndex = 40;
            btnGuardarDatos.Text = "Guardar Datos Modificados";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(590, 446);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 24;
            label1.Text = "Nombre Completo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(590, 517);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 28;
            label4.Text = "Nombre Usuario";
            // 
            // txtMostrarNombre
            // 
            txtMostrarNombre.Location = new Point(590, 478);
            txtMostrarNombre.Name = "txtMostrarNombre";
            txtMostrarNombre.Size = new Size(214, 23);
            txtMostrarNombre.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(590, 589);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(29, 17);
            label8.TabIndex = 32;
            label8.Text = "DNI";
            // 
            // txtMostrarNombreUsuario
            // 
            txtMostrarNombreUsuario.Location = new Point(590, 549);
            txtMostrarNombreUsuario.Name = "txtMostrarNombreUsuario";
            txtMostrarNombreUsuario.Size = new Size(214, 23);
            txtMostrarNombreUsuario.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(590, 667);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 36;
            label6.Text = "Telefono";
            // 
            // txtMostrarDNI
            // 
            txtMostrarDNI.Location = new Point(590, 621);
            txtMostrarDNI.Name = "txtMostrarDNI";
            txtMostrarDNI.Size = new Size(214, 23);
            txtMostrarDNI.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(857, 667);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 38;
            label5.Text = "Residencia";
            // 
            // txtMostrarTelefono
            // 
            txtMostrarTelefono.Location = new Point(590, 699);
            txtMostrarTelefono.Name = "txtMostrarTelefono";
            txtMostrarTelefono.Size = new Size(214, 23);
            txtMostrarTelefono.TabIndex = 37;
            // 
            // btnModificarUsuarios
            // 
            btnModificarUsuarios.FlatStyle = FlatStyle.Flat;
            btnModificarUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarUsuarios.ForeColor = SystemColors.ButtonFace;
            btnModificarUsuarios.Location = new Point(776, 349);
            btnModificarUsuarios.Name = "btnModificarUsuarios";
            btnModificarUsuarios.Size = new Size(115, 48);
            btnModificarUsuarios.TabIndex = 25;
            btnModificarUsuarios.Text = "Modificar Datos";
            btnModificarUsuarios.UseVisualStyleBackColor = true;
            btnModificarUsuarios.Click += btnModificarUsuarios_Click;
            // 
            // txtMostrarResidencia
            // 
            txtMostrarResidencia.Location = new Point(857, 699);
            txtMostrarResidencia.Name = "txtMostrarResidencia";
            txtMostrarResidencia.Size = new Size(214, 23);
            txtMostrarResidencia.TabIndex = 39;
            // 
            // richText
            // 
            richText.BackColor = Color.LemonChiffon;
            richText.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richText.Location = new Point(590, 165);
            richText.Name = "richText";
            richText.Size = new Size(481, 153);
            richText.TabIndex = 4;
            richText.Text = resources.GetString("richText.Text");
            // 
            // txtMostrarApellido
            // 
            txtMostrarApellido.Location = new Point(857, 478);
            txtMostrarApellido.Name = "txtMostrarApellido";
            txtMostrarApellido.Size = new Size(214, 23);
            txtMostrarApellido.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(857, 589);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 34;
            label7.Text = "CUIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(857, 444);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 26;
            label2.Text = "Apellido";
            // 
            // txtMostrarCUIL
            // 
            txtMostrarCUIL.Location = new Point(857, 621);
            txtMostrarCUIL.Name = "txtMostrarCUIL";
            txtMostrarCUIL.Size = new Size(214, 23);
            txtMostrarCUIL.TabIndex = 35;
            // 
            // txtMostrarCorreo
            // 
            txtMostrarCorreo.Location = new Point(857, 549);
            txtMostrarCorreo.Name = "txtMostrarCorreo";
            txtMostrarCorreo.Size = new Size(214, 23);
            txtMostrarCorreo.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(857, 517);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 30;
            label3.Text = "Correo";
            // 
            // txtMostrarContraseña
            // 
            txtMostrarContraseña.Location = new Point(986, 517);
            txtMostrarContraseña.Name = "txtMostrarContraseña";
            txtMostrarContraseña.Size = new Size(85, 23);
            txtMostrarContraseña.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(910, 517);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 17);
            label9.TabIndex = 43;
            label9.Text = "Contraseña";

            // 
            // frmAdminDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 741);
            Controls.Add(userDataGridView);
            Controls.Add(pnIngreso);
            Name = "frmAdminDatos";
            Text = "frmAdminCuenta";
            pnTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            pnIngreso.ResumeLayout(false);
            pnIngreso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTitulo;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox tittleB;
        private RichTextBox richTextBox1;
        private DataGridView userDataGridView;
        private Panel pnIngreso;
        private Button btnModificarUsuarios;
        private RichTextBox richText;
        private Label label5;
        private TextBox txtMostrarResidencia;
        private TextBox txtMostrarApellido;
        private Label label7;
        private Label label2;
        private TextBox txtMostrarCUIL;
        private TextBox txtMostrarCorreo;
        private Label label3;
        private Label label6;
        private TextBox txtMostrarTelefono;
        private Label label8;
        private TextBox txtMostrarDNI;
        private Label label4;
        private TextBox txtMostrarNombreUsuario;
        private Label label1;
        private TextBox txtMostrarNombre;
        private Button btnGuardarDatos;
        private Button btnCargarDatos;
        private Label label9;
        private TextBox txtMostrarContraseña;
    }
}