namespace sistema_de_facturacion
{
    partial class HomeForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_facturar
            // 
            this.btn_facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturar.Location = new System.Drawing.Point(12, 80);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(239, 37);
            this.btn_facturar.TabIndex = 1;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(sistema_de_facturacion.Services.Facturacion.Articulo);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeForm
            // 
            this.ClientSize = new System.Drawing.Size(1052, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_facturar);
            this.Name = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private System.Windows.Forms.Button button1;
    }
}

