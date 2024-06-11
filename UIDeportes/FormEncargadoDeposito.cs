using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDeportes
{
    public partial class FormEncargadoDeposito : Form
    {
        FormAltaProducto formularioAltaProducto;
        FormBuscarProducto formularioBuscarProducto;
        FormVerStock formularioVerStock;
        FormEditarProducto formularioEditarProducto;
        FormEliminarProducto formularioEliminarProducto;
        public FormEncargadoDeposito()
        {
            InitializeComponent();
            formularioAltaProducto = new FormAltaProducto();
            formularioBuscarProducto = new FormBuscarProducto();    
            formularioVerStock = new FormVerStock();
            formularioEditarProducto = new FormEditarProducto();
            formularioEliminarProducto = new FormEliminarProducto();

        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioAltaProducto.Show();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioBuscarProducto.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioVerStock.Show();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioEditarProducto.Show();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioEliminarProducto.Show();
        }
    }
}
