namespace BC_Formularios.Menu_App.Menu_Mercado
{
    partial class frmAcciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcciones));
            pnIngreso = new Panel();
            richTextBox4 = new RichTextBox();
            btnCarga = new Button();
            richText = new RichTextBox();
            pnTitulo = new Panel();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            tittleB = new RichTextBox();
            richTextBox1 = new RichTextBox();
            dataGridViewAcciones = new DataGridView();
            nombreColumn = new DataGridViewTextBoxColumn();
            altaColumn = new DataGridViewTextBoxColumn();
            bajaColumn = new DataGridViewTextBoxColumn();
            cantidadColumn = new DataGridViewTextBoxColumn();
            venderColumn = new DataGridViewButtonColumn();
            comprarColumn = new DataGridViewButtonColumn();
            pnIngreso.SuspendLayout();
            pnTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAcciones).BeginInit();
            SuspendLayout();
            // 
            // pnIngreso
            // 
            pnIngreso.BackColor = Color.FromArgb(52, 52, 80);
            pnIngreso.Controls.Add(dataGridViewAcciones);
            pnIngreso.Controls.Add(richTextBox4);
            pnIngreso.Controls.Add(btnCarga);
            pnIngreso.Controls.Add(richText);
            pnIngreso.Controls.Add(pnTitulo);
            pnIngreso.Location = new Point(-2, 0);
            pnIngreso.Name = "pnIngreso";
            pnIngreso.Size = new Size(1129, 741);
            pnIngreso.TabIndex = 3;
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.LemonChiffon;
            richTextBox4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(685, 419);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(386, 107);
            richTextBox4.TabIndex = 26;
            richTextBox4.Text = "Con el boton de \"Carga de informe de Eliminacion\" abrira un archivo de texto el cual mostrara la cantidad de cuentas que han solicitado la eliminacion de su cuenta.";
            // 
            // btnCarga
            // 
            btnCarga.FlatStyle = FlatStyle.Flat;
            btnCarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarga.ForeColor = SystemColors.ButtonFace;
            btnCarga.Location = new Point(837, 582);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(96, 75);
            btnCarga.TabIndex = 25;
            btnCarga.Text = "Cargar Informe de Eliminacion";
            btnCarga.UseVisualStyleBackColor = true;
            // 
            // richText
            // 
            richText.BackColor = Color.LemonChiffon;
            richText.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richText.Location = new Point(685, 165);
            richText.Name = "richText";
            richText.Size = new Size(386, 193);
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
            richTextBox2.Text = ".ACCIONES";
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
            // dataGridViewAcciones
            // 
            dataGridViewAcciones.BackgroundColor = Color.FromArgb(55, 55, 95);
            dataGridViewAcciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAcciones.Columns.AddRange(new DataGridViewColumn[] { nombreColumn, altaColumn, bajaColumn, cantidadColumn, venderColumn, comprarColumn });
            dataGridViewAcciones.Location = new Point(3, 125);
            dataGridViewAcciones.Name = "dataGridViewAcciones";
            dataGridViewAcciones.RowTemplate.Height = 25;
            dataGridViewAcciones.Size = new Size(643, 616);
            dataGridViewAcciones.TabIndex = 27;
            // 
            // nombreColumn
            // 
            nombreColumn.HeaderText = "Nombre Accion";
            nombreColumn.Name = "nombreColumn";
            // 
            // altaColumn
            // 
            altaColumn.HeaderText = "Precio a Alta";
            altaColumn.Name = "altaColumn";
            // 
            // bajaColumn
            // 
            bajaColumn.HeaderText = "Precio a Baja ";
            bajaColumn.Name = "bajaColumn";
            // 
            // cantidadColumn
            // 
            cantidadColumn.HeaderText = "Cantidad Accion";
            cantidadColumn.Name = "cantidadColumn";
            // 
            // venderColumn
            // 
            venderColumn.HeaderText = "Vender";
            venderColumn.Name = "venderColumn";
            venderColumn.Resizable = DataGridViewTriState.True;
            venderColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            venderColumn.Text = "Vender";
            venderColumn.UseColumnTextForButtonValue = true;
            // 
            // comprarColumn
            // 
            comprarColumn.HeaderText = "Comprar";
            comprarColumn.Name = "comprarColumn";
            comprarColumn.Resizable = DataGridViewTriState.True;
            comprarColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            comprarColumn.Text = "Comprar";
            comprarColumn.UseColumnTextForButtonValue = true;
            // 
            // frmAcciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 741);
            Controls.Add(pnIngreso);
            Name = "frmAcciones";
            Text = "frmAcciones";
            pnIngreso.ResumeLayout(false);
            pnTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAcciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnIngreso;
        private RichTextBox richTextBox4;
        private Button btnCarga;
        private RichTextBox richText;
        private Panel pnTitulo;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox tittleB;
        private RichTextBox richTextBox1;
        private DataGridView dataGridViewAcciones;
        private DataGridViewTextBoxColumn nombreColumn;
        private DataGridViewTextBoxColumn altaColumn;
        private DataGridViewTextBoxColumn bajaColumn;
        private DataGridViewTextBoxColumn cantidadColumn;
        private DataGridViewButtonColumn venderColumn;
        private DataGridViewButtonColumn comprarColumn;
    }
}