namespace BC_Formularios.Menu_App.Menu_Mercado
{
    partial class frmDeposito
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
            richTextBox1 = new RichTextBox();
            tittleC = new RichTextBox();
            txtMonto = new TextBox();
            btnConfirmar = new Button();
            txtSaldo = new TextBox();
            lbNombreApellido = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 55, 95);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbNombreApellido);
            panel1.Controls.Add(txtSaldo);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(tittleC);
            panel1.Controls.Add(richTextBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 342);
            panel1.TabIndex = 3;
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
            // tittleC
            // 
            tittleC.BackColor = Color.FromArgb(55, 55, 90);
            tittleC.BorderStyle = BorderStyle.None;
            tittleC.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tittleC.ForeColor = Color.Transparent;
            tittleC.Location = new Point(224, 38);
            tittleC.Name = "tittleC";
            tittleC.Size = new Size(184, 48);
            tittleC.TabIndex = 35;
            tittleC.Text = ".DEPOSITO";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(255, 229);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(116, 23);
            txtMonto.TabIndex = 38;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(273, 276);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(79, 23);
            btnConfirmar.TabIndex = 37;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(255, 166);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(116, 23);
            txtSaldo.TabIndex = 39;
            // 
            // lbNombreApellido
            // 
            lbNombreApellido.AutoSize = true;
            lbNombreApellido.ForeColor = SystemColors.ControlLightLight;
            lbNombreApellido.Location = new Point(135, 169);
            lbNombreApellido.Name = "lbNombreApellido";
            lbNombreApellido.Size = new Size(103, 15);
            lbNombreApellido.TabIndex = 44;
            lbNombreApellido.Text = "Su saldo actual es:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(31, 232);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 45;
            label1.Text = "Ingrese el monto deseado a depositar:";
            // 
            // frmDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 342);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDeposito";
            Text = "Menu Deposito";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox tittleC;
        private RichTextBox richTextBox1;
        private TextBox txtSaldo;
        private TextBox txtMonto;
        private Button btnConfirmar;
        private Label label1;
        private Label lbNombreApellido;
    }
}