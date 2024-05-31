using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductoBE
    {
        private int _idProducto;

        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private long _precio;

        public long Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        private Stock _cantidad;
        public Stock Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private CategoriaProducto _categoria;
        public CategoriaProducto Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        private Proveedor _proveedor;
        public Proveedor Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        public ProductoBE() { }

        public ProductoBE(string nombre, long precio, Stock cantidad, CategoriaProducto categoria)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Categoria = categoria;
        }
    }
}
