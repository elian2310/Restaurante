using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RestauranteIS
{
    public partial class VistaFactura : MetroFramework.Forms.MetroForm
    {
        private List<Plato> pedido;
        private VistaIngredientes anterior;
        private String[] data;

        public VistaFactura(List<Plato> pedido, VistaIngredientes anterior)
        {
            this.pedido = pedido;
            this.anterior = anterior;
            data = new String[5];
            InitializeComponent();
            btnback.TileImage = Image.FromFile("..\\..\\img\\back.png");
            btnback.UseTileImage = true;
            
        }

        private void VistaFactura_Load(object sender, EventArgs e)
        {
            tbdatosf.Text = "Pedido: \r\n";
            mTxtExp.ForeColor = Color.Black;
            mTxtExp.Text = "mm/yy";
           
            /*teTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";*/
            foreach (Plato p in pedido)
            {
                tbdatosf.Text += p.GetNombre() + "-----" + p.GetCosto() + "\r\n";
            }
        }
        
        private void btnback_Click(object sender, EventArgs e)
        {
            VistaIngredientes iv = new VistaIngredientes(pedido);
            iv.Show();
            this.Hide();
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            String pattern = @"^(0[1-9]|1[0-2])\/([2-9][1-9])";
            bool isMatch = Regex.IsMatch(mTxtExp.Text, pattern);

            String pattern2 = @"^[0-9]+";
            bool isMatch2 = Regex.IsMatch(mTxtNIT.Text, pattern2);

            bool isMatch3 = Regex.IsMatch(mTxtTarjeta.Text, pattern2);

            if ((mTxtName1.Text.Length > 0) && isMatch2) //Nombre y Nit bien
            {

                data[0] = (metroTabControl1.SelectedTab.Text);
                data[1] = (mTxtName1.Text);
                data[2] = (mTxtNIT.Text);

                if (metroTabControl1.SelectedTab.Text == "TRANSACCION")
                {
                    //txtBox de TRANSACCION
                    if (isMatch && isMatch3)
                    {
                        data[3] = (mTxtTarjeta.Text);
                        data[4] = (mTxtExp.Text);
                        Factura fac = new Factura(data, pedido);
                        fac.Show();
                    }
                }
                else
                {
                    Factura fac = new Factura(data, pedido);
                    fac.Show();
                }
                
                
            }
            
        }

        private void mTxtExp_Enter(object sender, EventArgs e)
        {
            mTxtExp.Clear();
            mTxtExp.ForeColor = Color.Black;
        }

        private void tbdatosf_Click(object sender, EventArgs e)
        {

        }
    }
}
