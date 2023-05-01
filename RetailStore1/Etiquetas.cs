using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Etiqueta
    {
        public int IdEtiquetas { get; set; }
        public string Nombre { get; set; }

        public Etiqueta(int id, string nombre)
        {
            this.IdEtiquetas = id;
            this.Nombre = nombre;
        }
    }
}
