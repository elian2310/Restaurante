using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteIS
{
    public partial class VistaFactura : MetroFramework.Forms.MetroForm
    {
        private List<Plato> pedido;
        private TestIngredientView anterior;
        private String[] data;

        public VistaFactura(List<Plato> pedido, TestIngredientView anterior)
        {
            this.pedido = pedido;
            this.anterior = anterior;
            data = new String[4];
            InitializeComponent();
            btnback.TileImage = Image.FromFile("..\\..\\img\\back.png");
            btnback.UseTileImage = true;
            
        }

        private void VistaFactura_Load(object sender, EventArgs e)
        {
            tbdatosf.Text = "Pedido: \r\n";
            foreach (Plato p in pedido)
            {
                tbdatosf.Text += p.GetNombre() + "-----" + p.GetCosto() + "\r\n";
            }
        }
        
        private void btnback_Click(object sender, EventArgs e)
        {
            TestIngredientView iv = new TestIngredientView();
            iv.Show();
            this.Close();
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            
            if (metroTabControl1.SelectedTab.Text == "EFECTIVO")
            {
                //txtBox de efectivo
                data[0] = (metroTabControl1.SelectedTab.Text);
                data[1] = (mTxtName1.Text);
                data[2] = (mTxtNIT.Text);
                

            }
            else
            {
                //txtBox de tarjeta
                data[0] = (metroTabControl1.SelectedTab.Text);
                data[1] = (mTxtName2.Text);
                data[2] = (mTxtTarjeta.Text);
                data[3] = (mTxtExp.Text);
            }
            //OpenNewFormSending pedido and data
            Factura fac= new Factura(data, pedido);
            fac.Show();
        }
    }
}
