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
        public VistaFactura()
        {
            InitializeComponent();
            btnback.TileImage = Image.FromFile("..\\..\\img\\back.png");
            btnback.UseTileImage = true;
            
        }

        private void VistaFactura_Load(object sender, EventArgs e)
        {

        }
        
        private void btnback_Click(object sender, EventArgs e)
        {
            
        }
    }
}
