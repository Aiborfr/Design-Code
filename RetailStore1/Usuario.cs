using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore1
{

    public class Usuario
    {

        private int idUsuario;
        private string nombre;
        private string apellidos;
        private string email;
        private string contraseña;
        private string telefono;
        private string direccion;
        private string dni;
        private ListaDeseos listaDeseos;


        public Usuario(int idUsuario, string nombre, string apellidos, string email, string contraseña, string telefono, string direccion, string dni)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.contraseña = contraseña;
            this.telefono = telefono;
            this.direccion = direccion;
            this.dni = dni;
            this.listaDeseos = new ListaDeseos();
        }


        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public ListaDeseos ListaDeseos
        {
            get { return listaDeseos; }
            set { listaDeseos = value; }
        }


        public void AgregarProductoListaDeseos(Producto producto)
        {
            this.listaDeseos.AgregarProducto(producto);
        }

        public void EliminarProductoListaDeseos(int idProducto)
        {
            this.listaDeseos.EliminarProducto(idProducto);
        }

        public void MostrarListaDeseos()
        {
            Console.WriteLine("Lista de deseos de " + this.nombre + ":");
            this.listaDeseos.MostrarProductos();
        }

        public void DejarReseña(Producto producto, int valoracion, string comentario)
        {
            Reseña nuevaReseña = new Reseña(valoracion, comentario, this, producto);
            Reseña.Add(nuevaReseña);

        }
    }
}

