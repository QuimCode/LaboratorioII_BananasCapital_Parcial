namespace BC_Formularios.Menu_App.Menu_Administrativo
{
    partial class frmAdminTarjDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminTarjDatos));
            tittleB = new RichTextBox();
            richTextBox1 = new RichTextBox();
            pnTitulo = new Panel();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            userDataGridView = new DataGridView();
            pnIngreso = new Panel();
            btnEliminarTarjetas = new Button();
            btnCargaTarjetas = new Button();
            label6 = new Label();
            txtSaldo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSeguridad = new TextBox();
            txtTitular = new TextBox();
            label8 = new Label();
            richText = new RichTextBox();
            txtID = new TextBox();
            txtUsuario = new TextBox();
            txtNumeroTarjeta = new TextBox();
            pnTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            pnIngreso.SuspendLayout();
            SuspendLayout();
            // 
            // tittleB
            // 
            tittleB.BackColor = Color.FromArgb(39, 39, 70);
            tittleB.BorderStyle = BorderStyle.None;
            tittleB.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tittleB.ForeColor = Color.Transparent;
            tittleB.Location = new Point(220, 43);
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
            richTextBox1.Location = new Point(50, 43);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(175, 52);
            richTextBox1.TabIndex = 31;
            richTextBox1.Text = "BANANAS";
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
            pnTitulo.Size = new Size(1126, 139);
            pnTitulo.TabIndex = 0;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(39, 39, 70);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox2.ForeColor = Color.Transparent;
            richTextBox2.Location = new Point(761, 43);
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
            richTextBox3.Location = new Point(591, 43);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(175, 52);
            richTextBox3.TabIndex = 33;
            richTextBox3.Text = "BANANAS";
            // 
            // userDataGridView
            // 
            userDataGridView.BackgroundColor = Color.FromArgb(55, 55, 95);
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(168, 350);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowTemplate.Height = 25;
            userDataGridView.Size = new Size(739, 391);
            userDataGridView.TabIndex = 3;
            userDataGridView.CellDoubleClick += userDataGridView_CellDoubleClick;
            // 
            // pnIngreso
            // 
            pnIngreso.BackColor = Color.FromArgb(52, 52, 80);
            pnIngreso.Controls.Add(txtNumeroTarjeta);
            pnIngreso.Controls.Add(txtUsuario);
            pnIngreso.Controls.Add(txtID);
            pnIngreso.Controls.Add(userDataGridView);
            pnIngreso.Controls.Add(btnEliminarTarjetas);
            pnIngreso.Controls.Add(btnCargaTarjetas);
            pnIngreso.Controls.Add(label6);
            pnIngreso.Controls.Add(txtSaldo);
            pnIngreso.Controls.Add(label5);
            pnIngreso.Controls.Add(label4);
            pnIngreso.Controls.Add(label2);
            pnIngreso.Controls.Add(label1);
            pnIngreso.Controls.Add(txtSeguridad);
            pnIngreso.Controls.Add(txtTitular);
            pnIngreso.Controls.Add(label8);
            pnIngreso.Controls.Add(richText);
            pnIngreso.Controls.Add(pnTitulo);
            pnIngreso.Location = new Point(-2, 0);
            pnIngreso.Name = "pnIngreso";
            pnIngreso.Size = new Size(1129, 741);
            pnIngreso.TabIndex = 4;
            // 
            // btnEliminarTarjetas
            // 
            btnEliminarTarjetas.FlatStyle = FlatStyle.Flat;
            btnEliminarTarjetas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarTarjetas.ForeColor = SystemColors.ButtonFace;
            btnEliminarTarjetas.Location = new Point(519, 253);
            btnEliminarTarjetas.Name = "btnEliminarTarjetas";
            btnEliminarTarjetas.Size = new Size(96, 53);
            btnEliminarTarjetas.TabIndex = 68;
            btnEliminarTarjetas.Text = "Modificar Tarjeta";
            btnEliminarTarjetas.UseVisualStyleBackColor = true;
            btnEliminarTarjetas.Click += btnEliminarTarjetas_Click;
            // 
            // btnCargaTarjetas
            // 
            btnCargaTarjetas.FlatStyle = FlatStyle.Flat;
            btnCargaTarjetas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargaTarjetas.ForeColor = SystemColors.ButtonFace;
            btnCargaTarjetas.Location = new Point(519, 177);
            btnCargaTarjetas.Name = "btnCargaTarjetas";
            btnCargaTarjetas.Size = new Size(96, 54);
            btnCargaTarjetas.TabIndex = 67;
            btnCargaTarjetas.Text = "Carga de Tarjeta";
            btnCargaTarjetas.UseVisualStyleBackColor = true;
            btnCargaTarjetas.Click += btnCargaTarjetas_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(983, 252);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 17);
            label6.TabIndex = 66;
            label6.Text = "Saldo";
            // 
            // txtSaldo
            // 
            txtSaldo.Enabled = false;
            txtSaldo.Location = new Point(983, 283);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(121, 23);
            txtSaldo.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(862, 177);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 17);
            label5.TabIndex = 64;
            label5.Text = "Numero de Tarjeta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(736, 177);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 63;
            label4.Text = "Codigo Seguridad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(822, 253);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 61;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(660, 253);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 60;
            label1.Text = "Titular";
            // 
            // txtSeguridad
            // 
            txtSeguridad.Enabled = false;
            txtSeguridad.Location = new Point(736, 208);
            txtSeguridad.Name = "txtSeguridad";
            txtSeguridad.Size = new Size(104, 23);
            txtSeguridad.TabIndex = 57;
            // 
            // txtTitular
            // 
            txtTitular.Enabled = false;
            txtTitular.Location = new Point(660, 283);
            txtTitular.Name = "txtTitular";
            txtTitular.ReadOnly = true;
            txtTitular.Size = new Size(134, 23);
            txtTitular.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(660, 177);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(20, 17);
            label8.TabIndex = 53;
            label8.Text = "ID";
            // 
            // richText
            // 
            richText.BackColor = Color.LemonChiffon;
            richText.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richText.Location = new Point(28, 162);
            richText.Name = "richText";
            richText.Size = new Size(444, 158);
            richText.TabIndex = 52;
            richText.Text = resources.GetString("richText.Text");
            // 
            // txtID
            // 
            txtID.Location = new Point(660, 208);
            txtID.Name = "txtID";
            txtID.Size = new Size(52, 23);
            txtID.TabIndex = 69;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(822, 283);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(134, 23);
            txtUsuario.TabIndex = 70;
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Location = new Point(862, 208);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(242, 23);
            txtNumeroTarjeta.TabIndex = 71;
            // 
            // frmAdminTarjDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 741);
            Controls.Add(pnIngreso);
            Name = "frmAdminTarjDatos";
            Text = "frmAdminTarjDatos";
            pnTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            pnIngreso.ResumeLayout(false);
            pnIngreso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox tittleB;
        private RichTextBox richTextBox1;
        private Panel pnTitulo;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private DataGridView userDataGridView;
        private Panel pnIngreso;
        private Button btnEliminarTarjetas;
        private Button btnCargaTarjetas;
        private Label label6;
        private TextBox txtSaldo;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtSeguridad;
        private TextBox txtTitular;
        private Label label8;
        private RichTextBox richText;
        private TextBox txtNumeroTarjeta;
        private TextBox txtUsuario;
        private TextBox txtID;
    }
}