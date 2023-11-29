namespace BC_Formularios.Menu_App.Menu_Administrativo
{
    partial class frmAdminCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCuenta));
            userDataGridView = new DataGridView();
            pnIngreso = new Panel();
            label8 = new Label();
            txtMostrarID = new TextBox();
            btnEliminarUsuarios = new Button();
            richTextBox4 = new RichTextBox();
            btnCargaUsuarios = new Button();
            richText = new RichTextBox();
            pnTitulo = new Panel();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            tittleB = new RichTextBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            pnIngreso.SuspendLayout();
            pnTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // userDataGridView
            // 
            userDataGridView.BackgroundColor = Color.FromArgb(55, 55, 95);
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(-3, 349);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowTemplate.Height = 25;
            userDataGridView.Size = new Size(1126, 391);
            userDataGridView.TabIndex = 1;
            userDataGridView.CellDoubleClick += userDataGridView_CellDoubleClick;
            // 
            // pnIngreso
            // 
            pnIngreso.BackColor = Color.FromArgb(52, 52, 80);
            pnIngreso.Controls.Add(label8);
            pnIngreso.Controls.Add(txtMostrarID);
            pnIngreso.Controls.Add(btnEliminarUsuarios);
            pnIngreso.Controls.Add(richTextBox4);
            pnIngreso.Controls.Add(btnCargaUsuarios);
            pnIngreso.Controls.Add(richText);
            pnIngreso.Controls.Add(pnTitulo);
            pnIngreso.Location = new Point(-3, -1);
            pnIngreso.Name = "pnIngreso";
            pnIngreso.Size = new Size(1129, 741);
            pnIngreso.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(857, 265);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(20, 17);
            label8.TabIndex = 34;
            label8.Text = "ID";
            // 
            // txtMostrarID
            // 
            txtMostrarID.Enabled = false;
            txtMostrarID.Location = new Point(857, 290);
            txtMostrarID.Name = "txtMostrarID";
            txtMostrarID.Size = new Size(214, 23);
            txtMostrarID.TabIndex = 35;
            // 
            // btnEliminarUsuarios
            // 
            btnEliminarUsuarios.FlatStyle = FlatStyle.Flat;
            btnEliminarUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarUsuarios.ForeColor = SystemColors.ButtonFace;
            btnEliminarUsuarios.Location = new Point(728, 265);
            btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            btnEliminarUsuarios.Size = new Size(96, 48);
            btnEliminarUsuarios.TabIndex = 27;
            btnEliminarUsuarios.Text = "Eliminar Usuario";
            btnEliminarUsuarios.UseVisualStyleBackColor = true;
            btnEliminarUsuarios.Click += btnEliminarUsuarios_Click;
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.LemonChiffon;
            richTextBox4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(590, 160);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(481, 78);
            richTextBox4.TabIndex = 26;
            richTextBox4.Text = "Con el boton de \"Carga Usuario\" abrira un archivo de texto el cual mostrara la cantidad de cuentas que han solicitado la eliminacion de su cuenta.";
            // 
            // btnCargaUsuarios
            // 
            btnCargaUsuarios.FlatStyle = FlatStyle.Flat;
            btnCargaUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargaUsuarios.ForeColor = SystemColors.ButtonFace;
            btnCargaUsuarios.Location = new Point(590, 265);
            btnCargaUsuarios.Name = "btnCargaUsuarios";
            btnCargaUsuarios.Size = new Size(96, 48);
            btnCargaUsuarios.TabIndex = 25;
            btnCargaUsuarios.Text = "Carga de Usuarios";
            btnCargaUsuarios.UseVisualStyleBackColor = true;
            btnCargaUsuarios.Click += btnCargaUsuarios_Click;
            // 
            // richText
            // 
            richText.BackColor = Color.LemonChiffon;
            richText.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richText.Location = new Point(31, 160);
            richText.Name = "richText";
            richText.Size = new Size(481, 153);
            richText.TabIndex = 4;
            richText.Text = resources.GetString("richText.Text");
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
            // frmAdminCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 741);
            Controls.Add(userDataGridView);
            Controls.Add(pnIngreso);
            Name = "frmAdminCuenta";
            Text = "Menu Administrativo de Cuentas";
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            pnIngreso.ResumeLayout(false);
            pnIngreso.PerformLayout();
            pnTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userDataGridView;
        private Panel pnIngreso;
        private Panel pnTitulo;
        private RichTextBox tittleB;
        private RichTextBox richTextBox1;
        private RichTextBox richText;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private Button btnCargaUsuarios;
        private Button btnEliminarUsuarios;
        private Label label8;
        private TextBox txtMostrarID;
    }
}