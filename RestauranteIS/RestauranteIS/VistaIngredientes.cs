using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace RestauranteIS
{
    public partial class VistaIngredientes : MetroFramework.Forms.MetroForm
    {
        private List<Plato> pedido;
        public VistaIngredientes(List<Plato> pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dgv_ingredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GridUpdate();
        }

        public void GridUpdate()
        {
            dgv_ingredientes.Rows.Clear();
            dgv_ingredientes.RowTemplate.Height = 60;
            dgv_ingredientes.ColumnCount = 3;
            dgv_ingredientes.Columns[0].Name = "Nro.";
            dgv_ingredientes.Columns[1].Name = "Nombre";
            dgv_ingredientes.Columns[2].Name = "Subtotal";
            DataGridViewImageColumn imgn = new DataGridViewImageColumn();
            imgn.HeaderText = "Imagen";
            imgn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imgn.Name = "colImgn";
            dgv_ingredientes.Columns.Add(imgn);
            dgv_ingredientes.AllowUserToAddRows = false;
            dgv_ingredientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            foreach (Plato p in pedido)
            {
                /*ArrayList fila = new ArrayList();
                fila.Add(p.GetNro());
                fila.Add(p.GetNombre());
                fila.Add(p.CalcularCosto());
                dataGridView1.Rows.Add(fila.ToArray());*/
                MemoryStream ms = new MemoryStream();
                Image nimg = Image.FromFile(p.GetImagen());
                nimg.Save(ms, nimg.RawFormat);
                byte[] bimg = ms.ToArray();
                dgv_ingredientes.Rows.Add(p.GetNro(), p.GetNombre(), p.CalcularCosto(), bimg);
            }

            DataGridViewButtonColumn ingr = new DataGridViewButtonColumn();
            DataGridViewButtonColumn descartar = new DataGridViewButtonColumn();

            ingr.HeaderText = "Ingredientes/Extras";
            descartar.HeaderText = "Descartar";

            ingr.Name = "colIngr";
            descartar.Name = "colDesc";

            ingr.Text = "Editar";
            descartar.Text = "Descartar";
            ingr.UseColumnTextForButtonValue = true;
            descartar.UseColumnTextForButtonValue = true;

            dgv_ingredientes.Columns.Add(ingr);
            dgv_ingredientes.Columns.Add(descartar);
        }

        private void dgv_ingredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Plato plt = pedido.Find(x => x.GetNro().ToString() == dgv_ingredientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                TestManageIngreds tmi = new TestManageIngreds(pedido.Find(x => x.GetNro() == (int)dgv_ingredientes.Rows[e.RowIndex].Cells[0].Value), this);
                tmi.Show();
            }
            else if (e.ColumnIndex == 5)
            {
                pedido.Remove(pedido.Find(x => x.GetNro().ToString() == dgv_ingredientes.Rows[e.RowIndex].Cells[0].Value.ToString()));
                GridUpdate();
            }
        }

        private void btn_siguiente_ing_Click(object sender, EventArgs e)
        {
            VistaFactura fac = new VistaFactura(pedido, this);
            fac.Show();
            this.Close();
        }
    }
}
