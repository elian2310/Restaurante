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

        public VistaFactura(List<Plato> pedido, TestIngredientView anterior)
        {
            this.pedido = pedido;
            this.anterior = anterior;

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
    }
}
