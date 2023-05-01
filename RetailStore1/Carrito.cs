using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<Producto> Productos { get; set; }
    }

}
