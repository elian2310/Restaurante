namespace RestauranteIS
{
    partial class VistaFactura
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
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.lbldatos = new MetroFramework.Controls.MetroLabel();
            this.tbdatosf = new MetroFramework.Controls.MetroTextBox();
            this.lblmet = new MetroFramework.Controls.MetroLabel();
            this.cbmet = new MetroFramework.Controls.MetroComboBox();
            this.tbdatosc = new MetroFramework.Controls.MetroTextBox();
            this.btnpagar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(23, 63);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 50);
            this.btnback.TabIndex = 0;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Location = new System.Drawing.Point(23, 132);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(127, 20);
            this.lbldatos.TabIndex = 1;
            this.lbldatos.Text = "Datos de la factura:";
            // 
            // tbdatosf
            // 
            this.tbdatosf.Location = new System.Drawing.Point(23, 155);
            this.tbdatosf.Multiline = true;
            this.tbdatosf.Name = "tbdatosf";
            this.tbdatosf.Size = new System.Drawing.Size(300, 250);
            this.tbdatosf.TabIndex = 2;
            // 
            // lblmet
            // 
            this.lblmet.AutoSize = true;
            this.lblmet.Location = new System.Drawing.Point(430, 132);
            this.lblmet.Name = "lblmet";
            this.lblmet.Size = new System.Drawing.Size(115, 20);
            this.lblmet.TabIndex = 3;
            this.lblmet.Text = "Metodo de pago:";
            // 
            // cbmet
            // 
            this.cbmet.FormattingEnabled = true;
            this.cbmet.ItemHeight = 24;
            this.cbmet.Items.AddRange(new object[] {
            "Efectivo",
            "Codigo QR",
            "NFC",
            "Transaccion"});
            this.cbmet.Location = new System.Drawing.Point(430, 155);
            this.cbmet.Name = "cbmet";
            this.cbmet.Size = new System.Drawing.Size(121, 30);
            this.cbmet.TabIndex = 4;
            // 
            // tbdatosc
            // 
            this.tbdatosc.Location = new System.Drawing.Point(430, 256);
            this.tbdatosc.Multiline = true;
            this.tbdatosc.Name = "tbdatosc";
            this.tbdatosc.Size = new System.Drawing.Size(250, 100);
            this.tbdatosc.TabIndex = 5;
            this.tbdatosc.Text = "Datos requeridos:";
            this.tbdatosc.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnpagar
            // 
            this.btnpagar.Location = new System.Drawing.Point(516, 377);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(110, 50);
            this.btnpagar.TabIndex = 6;
            this.btnpagar.Text = "PAGAR";
            this.btnpagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VistaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.tbdatosc);
            this.Controls.Add(this.cbmet);
            this.Controls.Add(this.lblmet);
            this.Controls.Add(this.tbdatosf);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.btnback);
            this.Name = "VistaFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.VistaFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroLabel lbldatos;
        private MetroFramework.Controls.MetroTextBox tbdatosf;
        private MetroFramework.Controls.MetroLabel lblmet;
        private MetroFramework.Controls.MetroComboBox cbmet;
        private MetroFramework.Controls.MetroTextBox tbdatosc;
        private MetroFramework.Controls.MetroTile btnpagar;
    }
}