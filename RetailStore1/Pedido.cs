using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public decimal PrecioFinal { get; set; }

        public List<Producto> Productos { get; set; }
        public List<int> Cantidad { get; set; }
        public List<Pedidos_Productos> Pedidos_Productos { get; set; }
    }

}
