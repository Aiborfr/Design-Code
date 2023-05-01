using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{
    public class Direcciones
    {
        public int IdDireccion { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }
    }

}
