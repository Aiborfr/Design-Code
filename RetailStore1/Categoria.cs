using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; }
    }

}
