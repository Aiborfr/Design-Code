using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Pedidos_Productos
    {
        private int v;

        public Pedidos_Productos(int idPedido, int idProducto, int v)
        {
            IdPedido = idPedido;
            IdProducto = idProducto;
            this.v = v;
        }

        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }

        public Pedido Pedido { get; set; }
        public Producto Producto { get; set; }
    }

}
