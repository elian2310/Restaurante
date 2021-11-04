using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteIS
{
    public class Ingrediente
    {
        private String nombre;
        private int costoExtra;
        private bool incluido;
        
        public Ingrediente(String nombre, int costoExtra, bool isExtra)
        {
            this.nombre = nombre;
            this.costoExtra = costoExtra;
            if (isExtra)
                this.incluido = false;
            else
                this.incluido = true;
        }
        
        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void SetCostoExtra(int costoExtra)
        {
            this.costoExtra = costoExtra;
        }
        public void SetIncluido(bool incluido)
        {
            this.incluido = incluido;
        }
        public String GetNombre()
        {
            return nombre;
        }
        public int GetCostoExtra()
        {
            return costoExtra;
        }
        public bool GetIncluido()
        {
            return incluido;
        }
        public void ToggleIncluido()
        {
            incluido = !incluido;
        }
    }
}
