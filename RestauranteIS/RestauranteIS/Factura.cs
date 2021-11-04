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
    public partial class Factura : MetroFramework.Forms.MetroForm
    {
        private List<String> data;
        private List<Plato> pedido;
        private int total;

        public Factura(List<String> data, List<Plato> pedido)
        {
            this.data = data;
            this.pedido = pedido;
            total = 0;
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            mLblPlatos.Text = "";
            mLblPrecios.Text = "";
            foreach (Plato p in pedido)
            {
                mLblPlatos.Text += p.GetNombre() + "\r\n";
                mLblPrecios.Text += p.GetCosto() + "\r\n";
                total += p.GetCosto();
            }
            metroLabel7.Text = total.ToString();
        }
    }
}
