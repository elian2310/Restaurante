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
    public partial class TestIngredientView : Form
    {
        private List<Plato> pedido;
        public TestIngredientView(List<Plato> pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
           

        }

        private void TestIngredientView_Load(object sender, EventArgs e)
        {
            GridUpdate();
        }
        public void GridUpdate()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nro.";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Subtotal";
            DataGridViewImageColumn imgn = new DataGridViewImageColumn();
            imgn.HeaderText = "Imagen";
            imgn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imgn.Name = "colImgn";
            dataGridView1.Columns.Add(imgn);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

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
                dataGridView1.Rows.Add(p.GetNro(), p.GetNombre(), p.CalcularCosto(), bimg);
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
           
            dataGridView1.Columns.Add(ingr);
            dataGridView1.Columns.Add(descartar);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                ////MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Plato plt = pedido.Find(x => x.GetNro().ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //TestManageIngreds tmi = new TestManageIngreds(pedido.Find(x => x.GetNro() == (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value),this);
                //tmi.Show();
            }
            else if (e.ColumnIndex == 5)
            {
                pedido.Remove(pedido.Find(x => x.GetNro().ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                GridUpdate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VistaFactura fac = new VistaFactura(pedido, this);
            //fac.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
