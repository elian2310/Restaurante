using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteIS
{
    class Categoría
    {
        private String nombre;
        private String imagen;
        private List<Plato> platos;

        public Categoría(String nombre, String imagen)
        {
            this.nombre = nombre;
            this.imagen = imagen;
            this.platos = new List<Plato>();
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void SetImagen(String imagen)
        {
            this.imagen = imagen;
        }
        public String GetNombre()
        {
            return nombre;
        }
        public String GetImagen()
        {
            return imagen;
        }
        public void AddPlato(Plato plato)
        {
            platos.Add(plato);
        }
        public void DelPlato(String plato)
        {
            platos.Remove(platos.Find(x => x.GetNombre() == plato));
        }
        public Plato FindPlato(String plato)
        {
            return platos.Find(x => x.GetNombre() == plato);
        }
    }
}
