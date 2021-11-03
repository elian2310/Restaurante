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
        public TestIngredientView()
        {
            InitializeComponent();
            this.pedido = new List<Plato>();
            pedido.Add(new Plato("Hamburguesa", "..\\..\\img\\hamburg.png", 20, 1));
            pedido.Add(new Plato("Jugo de Frutas", "..\\..\\img\\jugof.jpg", 5, 2));
            pedido[0].AddIngrediente(new Ingrediente("Queso", 2, false));
            pedido[0].AddIngrediente(new Ingrediente("Cebolla", 2, false));
            pedido[0].AddIngrediente(new Ingrediente("Tomate", 2, false));
            pedido[0].AddExtra(new Ingrediente("Doble queso", 5, true));
            pedido[0].AddExtra(new Ingrediente("Llajua", 3, true));
            pedido[1].AddExtra(new Ingrediente("Hielo", 1, true));

        }

        private void TestIngredientView_Load(object sender, EventArgs e)
        {
            GridUpdate();
        }
        public void GridUpdate()
        {
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

        }
    }
}
