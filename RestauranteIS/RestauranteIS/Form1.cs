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
    public partial class Form1 : Form
    {
        Ingrediente papa;
        Ingrediente ensalada;
        Ingrediente pan;
        Ingrediente lechuga;
        Ingrediente tomate;
        Ingrediente picante;
        Ingrediente yuca;
        Ingrediente papas;
        Ingrediente crema;
        Ingrediente agua;
        Ingrediente chispasDeChocolate;
        Ingrediente hielo;

        Plato silpancho;
        Plato hamburguesa;
        Plato pique;
        Plato canela;
        Plato limon;
        Plato vainilla;
        Plato moconchinchi;
        Plato limonada;
        Plato soda;

        Categoría almuerzos;
        Categoría helados;
        Categoría refrescos;

        List<Categoría> categorias;
        List<Plato> platos;

        TestIngredientView ts;

        int cantidad;
        string platoSeleccionado;
        public Form1()
        {
            InitializeComponent();
            papa = new Ingrediente("Papa", 5, true);
            ensalada = new Ingrediente("Ensalada", 5, true);
            pan = new Ingrediente("Pan", 5, true);
            lechuga = new Ingrediente("Lechuga", 5, true);
            tomate = new Ingrediente("Tomate", 5, true);
            picante = new Ingrediente("Picante", 5, true);
            yuca = new Ingrediente("Yuca", 5, true);
            papas = new Ingrediente("Papas", 5, true);
            crema = new Ingrediente("Crema", 5, true);
            agua = new Ingrediente("Agua", 5, true);
            chispasDeChocolate = new Ingrediente("Chispas de chocolate", 5, true);
            hielo = new Ingrediente("Hielo", 5, true);

            almuerzos = new Categoría("Almuerzos");
            helados = new Categoría("Helados");
            refrescos = new Categoría("Refrescos");

            crearSilpancho();
            crearHamburguesa();
            crearPique();
            crearCanela();
            crearLimon();
            crearVainilla();
            crearMoconchinchi();
            crearSoda();
            crearLimonada();

            categorias = new List<Categoría>();
            platos = new List<Plato>();

            cantidad = 0;

            Emparejar();
            dibujarCategorias();

        }
        private Plato crearSilpancho()
        {
            silpancho = new Plato("Silpancho", "..\\..\\img\\silpancho.jpg", 15);
            silpancho.AddIngrediente(papa);
            silpancho.AddIngrediente(ensalada);
            return silpancho;
        }
        private Plato crearHamburguesa()
        {
            hamburguesa = new Plato("Hamburguesa", "..\\..\\img\\hamburguesa.jpg", 20);
            hamburguesa.AddIngrediente(pan);
            hamburguesa.AddIngrediente(lechuga);
            hamburguesa.AddIngrediente(tomate);
            return hamburguesa;
        }

        private Plato crearPique()
        {
            pique = new Plato("Pique", "..\\..\\img\\pique.jpg", 70);
            pique.AddIngrediente(picante);
            return pique;
        }

        private Plato crearCanela()
        {
            canela = new Plato("Canela", "..\\..\\img\\canela.jpg", 7);
            canela.AddIngrediente(agua);
            return canela;
        }

        private Plato crearLimon()
        {
            limon = new Plato("Limon", "..\\..\\img\\limon.jpg", 7);
            limon.AddIngrediente(crema);
            return limon;
        }

        private Plato crearVainilla()
        {
            vainilla = new Plato("Vainilla", "..\\..\\img\\vainilla.png", 7);
            vainilla.AddIngrediente(crema);
            return vainilla;
        }

        private Plato crearMoconchinchi()
        {
            moconchinchi = new Plato("Moconchinchi", "..\\..\\img\\moconchinchi.jpg", 5);
            return moconchinchi;
        }

        private Plato crearLimonada()
        {
            limonada = new Plato("Limonada", "..\\..\\img\\limonada.jpg", 5);
            return limonada;
        }

        private Plato crearSoda()
        {
            soda = new Plato("Soda", "..\\..\\img\\sodas.jpg", 5);
            return soda;
        }



        private void Emparejar()
        {
            categorias.Add(almuerzos);
            categorias.Add(helados);
            categorias.Add(refrescos);

            almuerzos.AddPlato(pique);
            almuerzos.AddPlato(silpancho);
            almuerzos.AddPlato(hamburguesa);

            helados.AddPlato(limon);
            helados.AddPlato(canela);
            helados.AddPlato(vainilla);

            refrescos.AddPlato(moconchinchi);
            refrescos.AddPlato(limonada);
            refrescos.AddPlato(soda);
        }

        private void dibujarCategorias()
        {
            foreach (Categoría categoria in categorias)
            {
                Button btn = new Button();
                btn.Text = categoria.GetNombre();
                btn.Height = 80;
                btn.Width = 470;
                flowLayoutPanel2.Controls.Add(btn);
                btn.Click += (sendr, EventArgs) => { dibujarPlatos(sendr, EventArgs, categoria); };


            }
        }

        private void dibujarPlatos(Object sender, EventArgs e, Categoría categoria)
        {
            flowLayoutPanel3.Controls.Clear();
            foreach (Plato plato in categoria.getPlatos())
            {
                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 400;
                pb.Width = 400;
                string img = plato.GetImagen();
                pb.Image = Image.FromFile(img);

                flowLayoutPanel3.Controls.Add(pb);
                mlblNombre.Text = "";
                mlblPrecio.Text = "";
                pb.Click += (sendr, EventArgs) => { mostrarDescripcion(sendr, EventArgs, plato); };


            }
        }

        private void mostrarDescripcion(Object sender, EventArgs e, Plato plato)
        {
            mlblNombre.Text = plato.GetNombre();
            mlblPrecio.Text = "Precio: " + plato.GetCosto().ToString() + " Bs.";

            platoSeleccionado = plato.GetNombre();
            cantidad = 0;
            mlblCantidad.Text = cantidad.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de su elección?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                switch (platoSeleccionado)
                {
                    case "Silpancho":

                        for (int i = 0; i < cantidad; i++)
                        {
                            platos.Add(crearSilpancho());
                        }

                        break;

                    case "Hamburguesa":

                        for (int i = 0; i < cantidad; i++)
                        {
                            platos.Add(crearHamburguesa());
                        }

                        break;

                    case "Pique":

                        for (int i = 0; i < cantidad; i++)
                        {
                            platos.Add(crearPique());
                        }

                        break;

                    case "Canela":

                        for (int i = 0; i < cantidad; i++)
                        {
                            platos.Add(crearCanela());
                        }

                        break;

                    case "Limon":

                        for (int i = 0; i < cantidad; i++)
                        {
                            platos.Add(crearLimon());
                        }

                        break;

                    case "Vainilla":

                        for (int i = 0; i < cantidad; i++)
                        {
                            platos.Add(crearVainilla());
                        }

                        break;

                    case "Moconchinchi":

                        for (int i = 0; i < cantidad; i++)
                        {
                            platos.Add(crearMoconchinchi());
                        }

                        break;

                    case "Limonada":

                        for (int i = 0; i < cantidad; i++)
                        {
                            platos.Add(crearLimonada());
                        }

                        break;

                    case "Soda":

                        for (int i = 0; i < cantidad; i++)
                        {
                            platos.Add(crearSoda());
                        }

                        break;
                }

                cantidad = 0;
                mlblCantidad.Text = cantidad.ToString();
                mlblNombre.Text = "";
                mlblPrecio.Text = "";

            }

            else
            {
                cantidad = 0;
                mlblCantidad.Text = cantidad.ToString();
                mlblNombre.Text = "";
                mlblCantidad.Text = "";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cantidad++;
            mlblCantidad.Text = cantidad.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cantidad > 0)
            {
                cantidad--;
                mlblCantidad.Text = cantidad.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ts = new TestIngredientView(platos);
            ts.Show();
        }
    }
}
