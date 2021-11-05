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
            this.btnpagar = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mTxtNIT = new MetroFramework.Controls.MetroTextBox();
            this.mTxtName1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.mTxtTarjeta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mTxtExp = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
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
            this.lbldatos.Size = new System.Drawing.Size(117, 20);
            this.lbldatos.TabIndex = 1;
            this.lbldatos.Text = "Datos del pedido:";
            // 
            // tbdatosf
            // 
            this.tbdatosf.Location = new System.Drawing.Point(23, 155);
            this.tbdatosf.Multiline = true;
            this.tbdatosf.Name = "tbdatosf";
            this.tbdatosf.Size = new System.Drawing.Size(354, 250);
            this.tbdatosf.TabIndex = 2;
            // 
            // lblmet
            // 
            this.lblmet.AutoSize = true;
            this.lblmet.Location = new System.Drawing.Point(419, 155);
            this.lblmet.Name = "lblmet";
            this.lblmet.Size = new System.Drawing.Size(115, 20);
            this.lblmet.TabIndex = 3;
            this.lblmet.Text = "Metodo de pago:";
            // 
            // btnpagar
            // 
            this.btnpagar.Location = new System.Drawing.Point(524, 355);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(110, 50);
            this.btnpagar.TabIndex = 6;
            this.btnpagar.Text = "PAGAR";
            this.btnpagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(419, 178);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(347, 146);
            this.metroTabControl1.TabIndex = 7;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(339, 103);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "EFECTIVO";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(445, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "NIT:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(445, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "NOMBRE:";
            // 
            // mTxtNIT
            // 
            this.mTxtNIT.Location = new System.Drawing.Point(557, 90);
            this.mTxtNIT.Name = "mTxtNIT";
            this.mTxtNIT.Size = new System.Drawing.Size(112, 23);
            this.mTxtNIT.TabIndex = 3;
            // 
            // mTxtName1
            // 
            this.mTxtName1.Location = new System.Drawing.Point(557, 57);
            this.mTxtName1.Name = "mTxtName1";
            this.mTxtName1.Size = new System.Drawing.Size(112, 23);
            this.mTxtName1.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.mTxtExp);
            this.metroTabPage2.Controls.Add(this.mTxtTarjeta);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(339, 103);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "TRANSACCION";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // mTxtTarjeta
            // 
            this.mTxtTarjeta.Location = new System.Drawing.Point(156, 23);
            this.mTxtTarjeta.Name = "mTxtTarjeta";
            this.mTxtTarjeta.Size = new System.Drawing.Size(114, 23);
            this.mTxtTarjeta.TabIndex = 6;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 58);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "FECHA EXP:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 23);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "NRO. TARJETA:";
            // 
            // mTxtExp
            // 
            this.mTxtExp.Location = new System.Drawing.Point(156, 54);
            this.mTxtExp.Name = "mTxtExp";
            this.mTxtExp.Size = new System.Drawing.Size(114, 23);
            this.mTxtExp.TabIndex = 7;
            this.mTxtExp.Enter += new System.EventHandler(this.mTxtExp_Enter);
            // 
            // VistaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblmet);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbdatosf);
            this.Controls.Add(this.mTxtNIT);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.mTxtName1);
            this.Controls.Add(this.btnback);
            this.Name = "VistaFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.VistaFactura_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroLabel lbldatos;
        private MetroFramework.Controls.MetroTextBox tbdatosf;
        private MetroFramework.Controls.MetroLabel lblmet;
        private MetroFramework.Controls.MetroTile btnpagar;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mTxtNIT;
        private MetroFramework.Controls.MetroTextBox mTxtName1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox mTxtTarjeta;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mTxtExp;
    }
}