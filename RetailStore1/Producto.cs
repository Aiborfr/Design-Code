using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Producto
    {
        private int v1;
        private string v2;
        private string v3;
        private decimal v4;
        private string v5;

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Descuento { get; set; }

        public int IdSubcategoria { get; set; }
        public Subcategoria Subcategoria { get; set; }

        public int IdSubcategoriaEspecializada { get; set; }
        public Subcategoria SubcategoriaEspecializada { get; set; }

        public List<Reseña> Reseñas { get; set; }

        public Producto()
        {
            Reseñas = new List<Reseña>();
        }

        public Producto(int v1, string v2, string v3, decimal v4, string v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public void DejarReseña(Usuario usuario, int valoracion, string comentario)
        {
            Reseña reseña = new Reseña(valoracion, comentario, usuario, this);
            Reseñas.Add(reseña);
        }


        public List<Reseña> ObtenerReseñas()
        {
            return Reseñas;
        }

        public double ObtenerValoracionPromedio()
        {
            if (Reseñas.Count == 0)
            {
                return 0;
            }

            int totalValoracion = 0;
            foreach (Reseña reseña in Reseñas)
            {
                totalValoracion += reseña.Valoracion;
            }

            return (double)totalValoracion / Reseñas.Count;
        }

        public decimal CalcularPrecioConDescuento()
        {
            if (Descuento)
            {
                return Precio * 0.9M;
            }
            else
            {
                return Precio;
            }
        }
    }

}
