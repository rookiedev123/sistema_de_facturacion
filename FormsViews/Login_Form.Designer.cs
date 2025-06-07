using System;

namespace sistema_de_facturacion.FormsViews
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbnNombre = new System.Windows.Forms.Label();
            this.lbnContraseña = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbnTutulo = new System.Windows.Forms.Label();
            this.lbnCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.AllowDrop = true;
            this.txtUsername.Location = new System.Drawing.Point(167, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(108, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(108, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbnNombre
            // 
            this.lbnNombre.AutoSize = true;
            this.lbnNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbnNombre.Location = new System.Drawing.Point(40, 128);
            this.lbnNombre.Name = "lbnNombre";
            this.lbnNombre.Size = new System.Drawing.Size(99, 13);
            this.lbnNombre.TabIndex = 2;
            this.lbnNombre.Text = "Nombre de usuario:";
            // 
            // lbnContraseña
            // 
            this.lbnContraseña.AutoSize = true;
            this.lbnContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbnContraseña.Location = new System.Drawing.Point(40, 177);
            this.lbnContraseña.Name = "lbnContraseña";
            this.lbnContraseña.Size = new System.Drawing.Size(64, 13);
            this.lbnContraseña.TabIndex = 3;
            this.lbnContraseña.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(54, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(200, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // lbnTutulo
            // 
            this.lbnTutulo.AutoSize = true;
            this.lbnTutulo.BackColor = System.Drawing.Color.Transparent;
            this.lbnTutulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTutulo.Location = new System.Drawing.Point(78, 46);
            this.lbnTutulo.Name = "lbnTutulo";
            this.lbnTutulo.Size = new System.Drawing.Size(189, 31);
            this.lbnTutulo.TabIndex = 6;
            this.lbnTutulo.Text = "Ferreteria Max";
            // 
            // lbnCopy
            // 
            this.lbnCopy.AutoSize = true;
            this.lbnCopy.BackColor = System.Drawing.Color.Transparent;
            this.lbnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnCopy.Location = new System.Drawing.Point(81, 328);
            this.lbnCopy.Name = "lbnCopy";
            this.lbnCopy.Size = new System.Drawing.Size(242, 13);
            this.lbnCopy.TabIndex = 7;
            this.lbnCopy.Text = "All Rights Reserved Team Engineers UTEC © 2025";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 350);
            this.Controls.Add(this.lbnCopy);
            this.Controls.Add(this.lbnTutulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbnContraseña);
            this.Controls.Add(this.lbnNombre);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Login_Form";
            this.Text = "Sistema de Inventario 1.1";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

            private void Login_Form_Load(object sender, EventArgs e)
            {
            Console.WriteLine("Formulario de inicio de sesión cargado.");
            }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbnNombre;
        private System.Windows.Forms.Label lbnContraseña;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbnTutulo;
        private System.Windows.Forms.Label lbnCopy;
    }
}