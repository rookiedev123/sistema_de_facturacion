namespace sistema_de_facturacion.Forms
{
    partial class TicketForm
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
            this.ticket_richTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticket_richTextBox
            // 
            this.ticket_richTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_richTextBox.Location = new System.Drawing.Point(12, 12);
            this.ticket_richTextBox.Name = "ticket_richTextBox";
            this.ticket_richTextBox.Size = new System.Drawing.Size(315, 480);
            this.ticket_richTextBox.TabIndex = 0;
            this.ticket_richTextBox.Text = "";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(123, 528);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "IMPRIMIR";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 575);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.ticket_richTextBox);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ticket_richTextBox;
        private System.Windows.Forms.Button btn_print;
    }
}