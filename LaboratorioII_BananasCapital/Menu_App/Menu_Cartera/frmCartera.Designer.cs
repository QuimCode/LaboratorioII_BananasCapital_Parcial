﻿namespace BC_Formularios.Menu_App
{
    partial class frmCartera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartera));
            panel1 = new Panel();
            txtUsuarioTarjeta = new TextBox();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            btnRegistro = new Button();
            lbVencimiento = new Label();
            lnCodigoSeguridad = new Label();
            lbNumeroTarjeta = new Label();
            lbNombreApellido = new Label();
            txtVencimiento = new TextBox();
            txtCCV = new TextBox();
            txtNumeroTarjeta = new TextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            tittleC = new RichTextBox();
            txtUser = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 55, 95);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(txtUsuarioTarjeta);
            panel1.Controls.Add(richTextBox5);
            panel1.Controls.Add(richTextBox6);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox4);
            panel1.Controls.Add(btnRegistro);
            panel1.Controls.Add(lbVencimiento);
            panel1.Controls.Add(lnCodigoSeguridad);
            panel1.Controls.Add(lbNumeroTarjeta);
            panel1.Controls.Add(lbNombreApellido);
            panel1.Controls.Add(txtVencimiento);
            panel1.Controls.Add(txtCCV);
            panel1.Controls.Add(txtNumeroTarjeta);
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(tittleC);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1132, 482);
            panel1.TabIndex = 2;
            // 
            // txtUsuarioTarjeta
            // 
            txtUsuarioTarjeta.Location = new Point(165, 309);
            txtUsuarioTarjeta.Name = "txtUsuarioTarjeta";
            txtUsuarioTarjeta.Size = new Size(224, 23);
            txtUsuarioTarjeta.TabIndex = 52;
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.FromArgb(55, 55, 90);
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox5.ForeColor = Color.Khaki;
            richTextBox5.Location = new Point(785, 44);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(173, 52);
            richTextBox5.TabIndex = 51;
            richTextBox5.Text = "BANANAS";
            // 
            // richTextBox6
            // 
            richTextBox6.BackColor = Color.FromArgb(55, 55, 90);
            richTextBox6.BorderStyle = BorderStyle.None;
            richTextBox6.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox6.ForeColor = Color.Transparent;
            richTextBox6.Location = new Point(889, 82);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(168, 48);
            richTextBox6.TabIndex = 50;
            richTextBox6.Text = ".CARTERA";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(55, 55, 90);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox3.ForeColor = Color.Khaki;
            richTextBox3.Location = new Point(407, 44);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(173, 52);
            richTextBox3.TabIndex = 49;
            richTextBox3.Text = "BANANAS";
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.FromArgb(55, 55, 90);
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox4.ForeColor = Color.Transparent;
            richTextBox4.Location = new Point(511, 82);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(168, 48);
            richTextBox4.TabIndex = 48;
            richTextBox4.Text = ".CARTERA";
            // 
            // btnRegistro
            // 
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.ForeColor = SystemColors.ButtonFace;
            btnRegistro.Location = new Point(756, 367);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(147, 34);
            btnRegistro.TabIndex = 47;
            btnRegistro.Text = "Registrar Tarjeta";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // lbVencimiento
            // 
            lbVencimiento.AutoSize = true;
            lbVencimiento.ForeColor = SystemColors.ControlLight;
            lbVencimiento.Location = new Point(164, 351);
            lbVencimiento.Name = "lbVencimiento";
            lbVencimiento.Size = new Size(123, 15);
            lbVencimiento.TabIndex = 46;
            lbVencimiento.Text = "Fecha de Vencimiento";
            // 
            // lnCodigoSeguridad
            // 
            lnCodigoSeguridad.AutoSize = true;
            lnCodigoSeguridad.ForeColor = SystemColors.ControlLightLight;
            lnCodigoSeguridad.Location = new Point(715, 281);
            lnCodigoSeguridad.Name = "lnCodigoSeguridad";
            lnCodigoSeguridad.Size = new Size(146, 15);
            lnCodigoSeguridad.TabIndex = 45;
            lnCodigoSeguridad.Text = "CCV/Codigo de Seguridad";
            // 
            // lbNumeroTarjeta
            // 
            lbNumeroTarjeta.AutoSize = true;
            lbNumeroTarjeta.ForeColor = SystemColors.ControlLightLight;
            lbNumeroTarjeta.Location = new Point(443, 351);
            lbNumeroTarjeta.Name = "lbNumeroTarjeta";
            lbNumeroTarjeta.Size = new Size(104, 15);
            lbNumeroTarjeta.TabIndex = 44;
            lbNumeroTarjeta.Text = "Numero de Tarjeta";
            // 
            // lbNombreApellido
            // 
            lbNombreApellido.AutoSize = true;
            lbNombreApellido.ForeColor = SystemColors.ControlLightLight;
            lbNombreApellido.Location = new Point(164, 281);
            lbNombreApellido.Name = "lbNombreApellido";
            lbNombreApellido.Size = new Size(107, 15);
            lbNombreApellido.TabIndex = 43;
            lbNombreApellido.Text = "Nombre Completo";
            // 
            // txtVencimiento
            // 
            txtVencimiento.Location = new Point(164, 374);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.Size = new Size(225, 23);
            txtVencimiento.TabIndex = 41;
            // 
            // txtCCV
            // 
            txtCCV.Location = new Point(715, 309);
            txtCCV.Name = "txtCCV";
            txtCCV.Size = new Size(225, 23);
            txtCCV.TabIndex = 40;
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Location = new Point(443, 374);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(225, 23);
            txtNumeroTarjeta.TabIndex = 39;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.PaleGoldenrod;
            richTextBox2.BulletIndent = 5;
            richTextBox2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox2.Location = new Point(60, 172);
            richTextBox2.Margin = new Padding(5);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(997, 70);
            richTextBox2.TabIndex = 37;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(55, 55, 90);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.Khaki;
            richTextBox1.Location = new Point(60, 44);
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
            tittleC.Location = new Point(164, 82);
            tittleC.Name = "tittleC";
            tittleC.Size = new Size(168, 48);
            tittleC.TabIndex = 35;
            tittleC.Text = ".CARTERA";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(443, 309);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(224, 23);
            txtUser.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(443, 281);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 54;
            label1.Text = "Usuario Operario";
            // 
            // frmCartera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 476);
            Controls.Add(panel1);
            Name = "frmCartera";
            Text = "Menu Cartera";
            Load += MenuMercado_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox tittleC;
        private Label lbVencimiento;
        private Label lnCodigoSeguridad;
        private Label lbNumeroTarjeta;
        private Label lbNombreApellido;
        private TextBox txtVencimiento;
        private TextBox txtCCV;
        private TextBox txtNumeroTarjeta;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Button btnRegistro;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private TextBox txtUsuarioTarjeta;
        private Label label1;
        private TextBox txtUser;
    }
}