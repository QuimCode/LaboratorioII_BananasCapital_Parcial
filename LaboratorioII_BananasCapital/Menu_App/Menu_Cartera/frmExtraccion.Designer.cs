namespace BC_Formularios.Menu_App.Menu_Mercado
{
    partial class frmExtraccion
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
            panel1 = new Panel();
            label1 = new Label();
            lbNombreApellido = new Label();
            txtSaldoActual = new TextBox();
            txtMonto = new TextBox();
            btnConfirmar = new Button();
            tittleC = new RichTextBox();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 55, 95);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbNombreApellido);
            panel1.Controls.Add(txtSaldoActual);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(tittleC);
            panel1.Controls.Add(richTextBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 342);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(72, 224);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 45;
            label1.Text = "Ingrese el monto deseado a Extraer:";
            // 
            // lbNombreApellido
            // 
            lbNombreApellido.AutoSize = true;
            lbNombreApellido.ForeColor = SystemColors.ControlLightLight;
            lbNombreApellido.Location = new Point(163, 161);
            lbNombreApellido.Name = "lbNombreApellido";
            lbNombreApellido.Size = new Size(103, 15);
            lbNombreApellido.TabIndex = 44;
            lbNombreApellido.Text = "Su saldo actual es:";
            // 
            // txtSaldoActual
            // 
            txtSaldoActual.Location = new Point(283, 158);
            txtSaldoActual.Name = "txtSaldoActual";
            txtSaldoActual.Size = new Size(116, 23);
            txtSaldoActual.TabIndex = 39;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(283, 221);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(116, 23);
            txtMonto.TabIndex = 38;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(301, 268);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(79, 23);
            btnConfirmar.TabIndex = 37;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // tittleC
            // 
            tittleC.BackColor = Color.FromArgb(55, 55, 90);
            tittleC.BorderStyle = BorderStyle.None;
            tittleC.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tittleC.ForeColor = Color.Transparent;
            tittleC.Location = new Point(224, 38);
            tittleC.Name = "tittleC";
            tittleC.Size = new Size(237, 48);
            tittleC.TabIndex = 35;
            tittleC.Text = ".EXTRACCION";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(55, 55, 90);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.Khaki;
            richTextBox1.Location = new Point(45, 38);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(173, 52);
            richTextBox1.TabIndex = 36;
            richTextBox1.Text = "BANANAS";
            // 
            // frmExtraccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 342);
            Controls.Add(panel1);
            Name = "frmExtraccion";
            Text = "frmExtraccion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lbNombreApellido;
        private TextBox txtSaldoActual;
        private TextBox txtMonto;
        private Button btnConfirmar;
        private RichTextBox tittleC;
        private RichTextBox richTextBox1;
    }
}