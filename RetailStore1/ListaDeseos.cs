using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class ListaDeseos
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaCreacion { get; set; }

        internal void AgregarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        internal void EliminarProducto(int idProducto)
        {
            throw new NotImplementedException();
        }

        internal void MostrarProductos()
        {
            throw new NotImplementedException();
        }
    }
}
