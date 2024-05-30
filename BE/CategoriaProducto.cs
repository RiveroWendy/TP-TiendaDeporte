using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CategoriaProducto
    {
		private int _idCategoria;

		public int IdCategoria
		{
			get { return _idCategoria; }
			set { _idCategoria = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		public CategoriaProducto() { }
	}
}
