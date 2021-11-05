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
        private String[] data;
        private List<Plato> pedido;
        private int total;

        public Factura(String[] data, List<Plato> pedido)
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

            mLblNIT.Text = data[2];
            mLblName.Text = data[1];
            mLblPayment.Text = data[0];
            mLblDate.Text = DateTime.Now.ToString("M/d/yyyy");

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
