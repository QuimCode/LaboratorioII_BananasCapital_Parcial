﻿namespace BC_Formularios.Menu_App.Menu_Administrativo
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
            usuarioColumn = new DataGridViewTextBoxColumn();
            nombreColumn = new DataGridViewTextBoxColumn();
            apellidoColumn = new DataGridViewTextBoxColumn();
            correoColum = new DataGridViewTextBoxColumn();
            deleteColumn = new DataGridViewButtonColumn();
            pnIngreso = new Panel();
            pnTitulo = new Panel();
            tittleB = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richText = new RichTextBox();
            btnCarga = new Button();
            richTextBox4 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            pnIngreso.SuspendLayout();
            pnTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // userDataGridView
            // 
            userDataGridView.BackgroundColor = Color.FromArgb(55, 55, 95);
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Columns.AddRange(new DataGridViewColumn[] { usuarioColumn, nombreColumn, apellidoColumn, correoColum, deleteColumn });
            userDataGridView.Location = new Point(-3, 125);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowTemplate.Height = 25;
            userDataGridView.Size = new Size(543, 619);
            userDataGridView.TabIndex = 1;
            // 
            // usuarioColumn
            // 
            usuarioColumn.HeaderText = "Usuario";
            usuarioColumn.Name = "usuarioColumn";
            // 
            // nombreColumn
            // 
            nombreColumn.HeaderText = "Nombre";
            nombreColumn.Name = "nombreColumn";
            // 
            // apellidoColumn
            // 
            apellidoColumn.HeaderText = "Apellido";
            apellidoColumn.Name = "apellidoColumn";
            // 
            // correoColum
            // 
            correoColum.HeaderText = "Correo";
            correoColum.Name = "correoColum";
            // 
            // deleteColumn
            // 
            deleteColumn.HeaderText = "Eliminar";
            deleteColumn.Name = "deleteColumn";
            deleteColumn.Text = "Delete User";
            deleteColumn.UseColumnTextForButtonValue = true;
            // 
            // pnIngreso
            // 
            pnIngreso.BackColor = Color.FromArgb(52, 52, 80);
            pnIngreso.Controls.Add(richTextBox4);
            pnIngreso.Controls.Add(btnCarga);
            pnIngreso.Controls.Add(richText);
            pnIngreso.Controls.Add(pnTitulo);
            pnIngreso.Location = new Point(-3, -1);
            pnIngreso.Name = "pnIngreso";
            pnIngreso.Size = new Size(1129, 741);
            pnIngreso.TabIndex = 2;
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
            // btnCarga
            // 
            btnCarga.FlatStyle = FlatStyle.Flat;
            btnCarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarga.ForeColor = SystemColors.ButtonFace;
            btnCarga.Location = new Point(780, 527);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(96, 75);
            btnCarga.TabIndex = 25;
            btnCarga.Text = "Cargar Informe de Eliminacion";
            btnCarga.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.LemonChiffon;
            richTextBox4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(590, 397);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(481, 78);
            richTextBox4.TabIndex = 26;
            richTextBox4.Text = "Con el boton de \"Carga de informe de Eliminacion\" abrira un archivo de texto el cual mostrara la cantidad de cuentas que han solicitado la eliminacion de su cuenta.";
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
            pnTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userDataGridView;
        private DataGridViewTextBoxColumn usuarioColumn;
        private DataGridViewTextBoxColumn nombreColumn;
        private DataGridViewTextBoxColumn apellidoColumn;
        private DataGridViewTextBoxColumn correoColum;
        private DataGridViewButtonColumn deleteColumn;
        private Panel pnIngreso;
        private Panel pnTitulo;
        private RichTextBox tittleB;
        private RichTextBox richTextBox1;
        private RichTextBox richText;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private Button btnCarga;
    }
}