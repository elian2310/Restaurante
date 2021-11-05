
namespace RestauranteIS
{
    partial class VistaIngredientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaIngredientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_atras_ing = new MetroFramework.Controls.MetroTile();
            this.btn_siguiente_ing = new MetroFramework.Controls.MetroTile();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.dgv_ingredientes = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_atras_ing);
            this.panel1.Controls.Add(this.btn_siguiente_ing);
            this.panel1.Controls.Add(this.metroScrollBar1);
            this.panel1.Controls.Add(this.dgv_ingredientes);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 328);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_atras_ing
            // 
            this.btn_atras_ing.Location = new System.Drawing.Point(55, 58);
            this.btn_atras_ing.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_atras_ing.Name = "btn_atras_ing";
            this.btn_atras_ing.Size = new System.Drawing.Size(50, 22);
            this.btn_atras_ing.TabIndex = 8;
            this.btn_atras_ing.Text = "Atrás";
            this.btn_atras_ing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_siguiente_ing
            // 
            this.btn_siguiente_ing.Location = new System.Drawing.Point(476, 58);
            this.btn_siguiente_ing.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btn_siguiente_ing.Name = "btn_siguiente_ing";
            this.btn_siguiente_ing.Size = new System.Drawing.Size(50, 22);
            this.btn_siguiente_ing.TabIndex = 7;
            this.btn_siguiente_ing.Text = "Siguiente";
            this.btn_siguiente_ing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_siguiente_ing.Click += new System.EventHandler(this.btn_siguiente_ing_Click);
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.Location = new System.Drawing.Point(4, 117);
            this.metroScrollBar1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.ScrollbarSize = 4;
            this.metroScrollBar1.Size = new System.Drawing.Size(4, 163);
            this.metroScrollBar1.TabIndex = 6;
            this.metroScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroScrollBar1_Scroll);
            // 
            // dgv_ingredientes
            // 
            this.dgv_ingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingredientes.Location = new System.Drawing.Point(36, 117);
            this.dgv_ingredientes.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgv_ingredientes.Name = "dgv_ingredientes";
            this.dgv_ingredientes.RowHeadersWidth = 102;
            this.dgv_ingredientes.RowTemplate.Height = 40;
            this.dgv_ingredientes.Size = new System.Drawing.Size(523, 192);
            this.dgv_ingredientes.TabIndex = 3;
            this.dgv_ingredientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ingredientes_CellClick);
            this.dgv_ingredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ingredientes_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(381, 41);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VistaIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 329);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "VistaIngredientes";
            this.Padding = new System.Windows.Forms.Padding(8, 25, 8, 8);
            this.Text = "VistaIngredientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private System.Windows.Forms.DataGridView dgv_ingredientes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btn_atras_ing;
        private MetroFramework.Controls.MetroTile btn_siguiente_ing;
    }
}