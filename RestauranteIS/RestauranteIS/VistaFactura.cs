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
        private List<String> data;

        public VistaFactura(List<Plato> pedido, TestIngredientView anterior)
        {
            this.pedido = pedido;
            this.anterior = anterior;
            data = new List<String>();
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
            
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            
            if (metroTabControl1.SelectedTab.Text == "EFECTIVO")
            {
                //txtBox de efectivo
                data.Add(metroTabControl1.SelectedTab.Text);
                data.Add(mTxtName1.Text);
                data.Add(mTxtNIT.Text);
                

            }
            else
            {
                //txtBox de tarjeta
                data.Add(metroTabControl1.SelectedTab.Text);
                data.Add(mTxtName2.Text);
                data.Add(mTxtTarjeta.Text);
                data.Add(mTxtExp.Text);
            }
            //OpenNewFormSending pedido and data
            Factura fac= new Factura(data, pedido);
            fac.Show();
        }
    }
}
