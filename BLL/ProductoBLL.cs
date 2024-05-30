using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoBLL
    {
        private List<ProductoBE> _productos;
        private ProductoDAL _productoDAL = new ProductoDAL();
        
        public ProductoBLL()
        {
            _productos = new List<ProductoBE>();
        }

        public void CrearProducto(int idProducto, string nombre, long precio, Stock cantidad, CategoriaProducto categoria, Proveedor proveedor)
        {
            ProductoBE nuevoProducto = new ProductoBE
            {
                IdProducto = idProducto,
                Nombre = nombre,
                Precio = precio,
                Cantidad = cantidad,
                Categoria = categoria,
                Proveedor = proveedor
            };
            _productos.Add(nuevoProducto);
        }

        public Stock VisualizarStock(int idProducto)
        {
            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto);
            return producto?.Cantidad;
        }

        public void EditarProducto(int idProducto, string nombre, long precio, Stock cantidad, CategoriaProducto categoria, Proveedor proveedor)
        {
            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto != null)
            {
                producto.Nombre = nombre;
                producto.Precio = precio;
                producto.Cantidad = cantidad;
                producto.Categoria = categoria;
                producto.Proveedor = proveedor;
            }
        }

        public void EliminarProducto(int idProducto)
        {
            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto != null)
            {
                _productos.Remove(producto);
            }
        }

        public ProductoBE BuscarProducto(int idProducto)
        {
            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto != null)
            {
                return producto;
            }
            else
            {
                DataTable productoData = _productoDAL.BuscarProducto(idProducto);
                if (productoData.Rows.Count > 0)
                {
                    DataRow row = productoData.Rows[0];
                    ProductoBE encontradoProducto = new ProductoBE
                    {
                        IdProducto = Convert.ToInt32(row["IdProducto"]),
                        Nombre = row["Nombre"].ToString(),
                        Precio = Convert.ToInt64(row["Precio"]),
                        //Cantidad = new Stock { Cantidad = Convert.ToInt32(row["Cantidad"]) },
                        //Categoria = new CategoriaProducto { Nombre = row["Categoria"].ToString() },
                        //Proveedor = new Proveedor { NombreEmpresa = row["Proveedor"].ToString() }
                    };
                    return encontradoProducto;
                }
                return null;
            }
        }
    }
}

