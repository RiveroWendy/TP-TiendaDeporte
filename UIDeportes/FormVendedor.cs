using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace UIDeportes
{
    public partial class FormVendedor : Form
    {
        FormDatosCliente formularioDatosCliente;
        FormCliente formularioCliente;
        FormBuscarVenta formularioBuscarVenta;
        FormGenerarVenta formularioGenerarVenta;
        public FormVendedor()
        {
            InitializeComponent();
            formularioDatosCliente = new FormDatosCliente();
            formularioCliente = new FormCliente();
            formularioBuscarVenta = new FormBuscarVenta();
            formularioGenerarVenta = new FormGenerarVenta();

        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioDatosCliente.Show();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioCliente.Show();
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioBuscarVenta.Show();
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioGenerarVenta.Show();
        }
    }
}
