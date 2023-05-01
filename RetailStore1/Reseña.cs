using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Reseña
    {
        public Reseña(int valoracion, string comentario, Usuario usuario, Producto producto)
        {
            Valoracion = valoracion;
            Comentario = comentario;
            Usuario = usuario;
            Producto = producto;
        }

        public int IdReseña { get; set; }
        public int Valoracion { get; set; }
        public string Comentario { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public int IdProducto { get; set; }
        public Producto Producto { get; set; }

        internal static void Add(Reseña nuevaReseña)
        {
            throw new NotImplementedException();
        }
    }
}
