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
    public partial class TestManageIngreds : Form
    {
        private Plato dish;
        private VistaIngredientes anterior;
        public TestManageIngreds(Plato dish, VistaIngredientes anterior)
        {
            InitializeComponent();
            this.dish = dish;
            this.anterior = anterior;
        }

        private void TestManageIngreds_Load(object sender, EventArgs e)
        {
            GridUpdate();
        }
        public void GridUpdate()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Tipo";
            dataGridView1.Columns[2].Name = "Costo";
            dataGridView1.Columns[3].Name = "Incluido";
            DataGridViewButtonColumn cbc = new DataGridViewButtonColumn();
            cbc.HeaderText = "Incluido";
            cbc.Name = "cbCol";
            cbc.Text = "Cambiar";
            cbc.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(cbc);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (Ingrediente i in dish.GetIngredientes())
            {
                String incld = "";
                if (i.GetIncluido())
                    incld = "Sí";
                else
                    incld = "No";
                dataGridView1.Rows.Add(i.GetNombre(), "Base", i.GetCostoExtra(), incld);
            }

            foreach (Ingrediente e in dish.GetExtras())
            {
                String incld = "";
                if (e.GetIncluido())
                    incld = "Sí";
                else
                    incld = "No";
                dataGridView1.Rows.Add(e.GetNombre(), "Extra", e.GetCostoExtra(), incld);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "Base")
                {
                    dish.GetIngredientes().Find(x => x.GetNombre() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).ToggleIncluido();
                    GridUpdate();
                    anterior.GridUpdate();
                }
                else
                {
                    dish.GetExtras().Find(x => x.GetNombre() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).ToggleIncluido();
                    GridUpdate();
                    anterior.GridUpdate();
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
