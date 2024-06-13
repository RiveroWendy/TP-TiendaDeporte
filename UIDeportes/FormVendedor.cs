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
using BLL;

namespace UIDeportes
{
    public partial class FormVendedor : Form
    {
        FormDatosCliente formularioDatosCliente;
        FormCliente formularioCliente;
        FormBuscarVenta formularioBuscarVenta;
        FormGenerarVenta formularioGenerarVenta;
        LoginBLL _login;
        public FormVendedor()
        {
            InitializeComponent();
            formularioDatosCliente = new FormDatosCliente();
            formularioCliente = new FormCliente();
            formularioBuscarVenta = new FormBuscarVenta();
            formularioGenerarVenta = new FormGenerarVenta();
            _login = new LoginBLL();

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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            _login.LogOut();
            this.Close();
            Form1 frm = Application.OpenForms["Form1"] as Form1;
            frm?.Show();
        }

        private void btnSalirPrograma_Click(object sender, EventArgs e)
        {
            List<Form> formulariosACerrar = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    formulariosACerrar.Add(form);
                }
            }

            foreach (Form form in formulariosACerrar)
            {
                form.Close();
            }
        }
    }
}
