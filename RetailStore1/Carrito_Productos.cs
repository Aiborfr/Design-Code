using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Carrito_Productos 
{
    public int IdCarrito { get; set; }
    public int IdProducto { get; set; }
    public int Cantidad { get; set; }
    
    public Carrito Carrito { get; set; }
    public Producto Producto { get; set; }
}

}
