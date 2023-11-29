namespace BC_Formularios.Menu_App.Menu_Administrativo
{
    partial class drmAdminTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drmAdminTarjeta));
            tittleB = new RichTextBox();
            richTextBox1 = new RichTextBox();
            pnTitulo = new Panel();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richText = new RichTextBox();
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
            txtUsuario = new TextBox();
            txtNumeroTarjeta = new TextBox();
            txtSeguridad = new TextBox();
            txtID = new TextBox();
            txtTitular = new TextBox();
            label8 = new Label();
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
            tittleB.Location = new Point(220, 38);
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
            richTextBox1.Location = new Point(50, 38);
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
            richTextBox2.Location = new Point(761, 38);
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
            richTextBox3.Location = new Point(591, 38);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(175, 52);
            richTextBox3.TabIndex = 33;
            richTextBox3.Text = "BANANAS";
            // 
            // richText
            // 
            richText.BackColor = Color.LemonChiffon;
            richText.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richText.Location = new Point(31, 169);
            richText.Name = "richText";
            richText.Size = new Size(444, 158);
            richText.TabIndex = 4;
            richText.Text = resources.GetString("richText.Text");
            // 
            // userDataGridView
            // 
            userDataGridView.BackgroundColor = Color.FromArgb(55, 55, 95);
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(3, 350);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowTemplate.Height = 25;
            userDataGridView.Size = new Size(1126, 391);
            userDataGridView.TabIndex = 3;
            userDataGridView.CellDoubleClick += userDataGridView_CellDoubleClick;
            // 
            // pnIngreso
            // 
            pnIngreso.BackColor = Color.FromArgb(52, 52, 80);
            pnIngreso.Controls.Add(btnEliminarTarjetas);
            pnIngreso.Controls.Add(btnCargaTarjetas);
            pnIngreso.Controls.Add(label6);
            pnIngreso.Controls.Add(txtSaldo);
            pnIngreso.Controls.Add(label5);
            pnIngreso.Controls.Add(label4);
            pnIngreso.Controls.Add(label2);
            pnIngreso.Controls.Add(label1);
            pnIngreso.Controls.Add(txtUsuario);
            pnIngreso.Controls.Add(txtNumeroTarjeta);
            pnIngreso.Controls.Add(txtSeguridad);
            pnIngreso.Controls.Add(txtID);
            pnIngreso.Controls.Add(userDataGridView);
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
            btnEliminarTarjetas.Location = new Point(522, 260);
            btnEliminarTarjetas.Name = "btnEliminarTarjetas";
            btnEliminarTarjetas.Size = new Size(96, 53);
            btnEliminarTarjetas.TabIndex = 51;
            btnEliminarTarjetas.Text = "Eliminar Tarjeta";
            btnEliminarTarjetas.UseVisualStyleBackColor = true;
            btnEliminarTarjetas.Click += btnEliminarTarjetas_Click;
            // 
            // btnCargaTarjetas
            // 
            btnCargaTarjetas.FlatStyle = FlatStyle.Flat;
            btnCargaTarjetas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargaTarjetas.ForeColor = SystemColors.ButtonFace;
            btnCargaTarjetas.Location = new Point(522, 184);
            btnCargaTarjetas.Name = "btnCargaTarjetas";
            btnCargaTarjetas.Size = new Size(96, 54);
            btnCargaTarjetas.TabIndex = 50;
            btnCargaTarjetas.Text = "Carga de Tarjeta";
            btnCargaTarjetas.UseVisualStyleBackColor = true;
            btnCargaTarjetas.Click += btnCargaTarjetas_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(983, 259);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 17);
            label6.TabIndex = 49;
            label6.Text = "Saldo";
            // 
            // txtSaldo
            // 
            txtSaldo.Enabled = false;
            txtSaldo.Location = new Point(983, 290);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.ReadOnly = true;
            txtSaldo.Size = new Size(119, 23);
            txtSaldo.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(865, 184);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 17);
            label5.TabIndex = 47;
            label5.Text = "Numero de Tarjeta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(739, 184);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 46;
            label4.Text = "Codigo Seguridad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(825, 260);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 44;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(663, 260);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 43;
            label1.Text = "Titular";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(825, 290);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(134, 23);
            txtUsuario.TabIndex = 42;
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Enabled = false;
            txtNumeroTarjeta.Location = new Point(865, 215);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.ReadOnly = true;
            txtNumeroTarjeta.Size = new Size(237, 23);
            txtNumeroTarjeta.TabIndex = 41;
            // 
            // txtSeguridad
            // 
            txtSeguridad.Enabled = false;
            txtSeguridad.Location = new Point(739, 215);
            txtSeguridad.Name = "txtSeguridad";
            txtSeguridad.ReadOnly = true;
            txtSeguridad.Size = new Size(104, 23);
            txtSeguridad.TabIndex = 38;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(663, 215);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(52, 23);
            txtID.TabIndex = 37;
            // 
            // txtTitular
            // 
            txtTitular.Enabled = false;
            txtTitular.Location = new Point(663, 290);
            txtTitular.Name = "txtTitular";
            txtTitular.ReadOnly = true;
            txtTitular.Size = new Size(134, 23);
            txtTitular.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(663, 184);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(20, 17);
            label8.TabIndex = 34;
            label8.Text = "ID";
            // 
            // drmAdminTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 741);
            Controls.Add(pnIngreso);
            Name = "drmAdminTarjeta";
            Text = "drmAdminTarjeta";
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
        private RichTextBox richText;
        private DataGridView userDataGridView;
        private Panel pnIngreso;
        private Label label8;
        private TextBox txtTitular;
        private TextBox txtNumeroTarjeta;
        private TextBox txtSeguridad;
        private TextBox txtID;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtUsuario;
        private Label label5;
        private Label label6;
        private TextBox txtSaldo;
        private Button btnEliminarTarjetas;
        private Button btnCargaTarjetas;
    }
}