using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Subcategoria
    {
        public int IdSubcategoria { get; set; }
        public string Nombre { get; set; }

        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }

        public List<Producto> Productos { get; set; }
    }

}
