using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Productos_Etiquetas
    {
        public int IdProducto { get; set; }
        public int IdEtiquetas { get; set; }

        public Producto Producto { get; set; }
        public Etiqueta Etiquetas { get; set; }
    }

}
