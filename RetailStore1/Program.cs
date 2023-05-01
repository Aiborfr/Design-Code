using System;
using System.Collections.Generic;

namespace RetailStore1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pedido pedido1 = new Pedido();
            pedido1.IdPedido = 1;
            pedido1.NumeroPedido = 12345;
            pedido1.FechaPedido = DateTime.Now;
            pedido1.PrecioFinal = 99.99m;

            
            Producto producto1 = new Producto(1, "Camisa", "Camisa de color azul", 29.99m, "Ropa");
            Producto producto2 = new Producto(2, "Pantalón", "Pantalón de mezclilla", 49.99m, "Ropa");

            pedido1.Productos = new List<Producto> { producto1, producto2 };
            pedido1.Cantidad = new List<int> { 1, 2 };
            pedido1.Pedidos_Productos = new List<Pedidos_Productos>();

            for (int i = 0; i < pedido1.Productos.Count; i++)
            {
                Pedidos_Productos pedidosProductos = new Pedidos_Productos(pedido1.IdPedido, pedido1.Productos[i].IdProducto, pedido1.Cantidad[i]);
                pedido1.Pedidos_Productos.Add(pedidosProductos);
            }

            
            Console.WriteLine("Detalles del pedido:");
            Console.WriteLine("ID del pedido: " + pedido1.IdPedido);
            Console.WriteLine("Número del pedido: " + pedido1.NumeroPedido);
            Console.WriteLine("Fecha del pedido: " + pedido1.FechaPedido);
            Console.WriteLine("Precio final: $" + pedido1.PrecioFinal);

            Console.WriteLine("Productos:");
            foreach (Pedidos_Productos pp in pedido1.Pedidos_Productos)
            {
                Console.WriteLine(pp.Cantidad + " x " + pp.Producto.Nombre + " - $" + pp.Producto.Precio);
            }

            Console.ReadLine();
        }
    }
}
