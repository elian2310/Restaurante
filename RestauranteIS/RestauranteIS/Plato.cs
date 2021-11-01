using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteIS
{
    class Plato
    {
        private String nombre;
        private String imagen;
        private int costo;
        private List<Ingrediente> ingredientes;
        private List<Ingrediente> extras;

        public Plato(String nombre, String imagen, int costo)
        {
            this.nombre = nombre;
            this.imagen = imagen;
            this.costo = costo;
            this.ingredientes = new List<Ingrediente>();
            this.extras = new List<Ingrediente>();
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void SetImagen(String imagen)
        {
            this.imagen = imagen;
        }
        public void SetCosto(int costo)
        {
            this.costo = costo;
        }
        public String GetNombre()
        {
            return nombre;
        }
        public String GetImagen()
        {
            return imagen;
        }
        public int GetCosto()
        {
            return costo;
        }
        public List<Ingrediente> GetIngredientes()
        {
            return ingredientes;
        }
        public List<Ingrediente> GetExtras()
        {
            return extras;
        }
        public void AddIngrediente(Ingrediente ingrediente)
        {
            ingredientes.Add(ingrediente);
        }
        public void AddExtra(Ingrediente extra)
        {
            ingredientes.Add(extra);
        }
        public void DelIngrediente(String ingrediente)
        {
            ingredientes.Remove(ingredientes.Find(x => x.GetNombre() == ingrediente));
        }
        public void DelExtra(String extra)
        {
            extras.Remove(extras.Find(x => x.GetNombre() == extra));
        }
        public void SetIncludeIngrediente(String nombre, bool incluido)
        {
            ingredientes.Find(x => x.GetNombre() == nombre).SetIncluido(incluido);
        }
        public void SetIncludeExtra(String nombre, bool incluido)
        {
            extras.Find(x => x.GetNombre() == nombre).SetIncluido(incluido);
        }
    }
}
