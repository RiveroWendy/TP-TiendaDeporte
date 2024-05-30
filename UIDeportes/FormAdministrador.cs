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
    public partial class FormAdministrador : Form
    {
        FormCrearUsuario formularioCrearUsuario;
        FormBuscarUsuario formularioBuscarUsuario;

        public FormAdministrador()
        {
            InitializeComponent();
            formularioCrearUsuario = new FormCrearUsuario();
            formularioBuscarUsuario = new FormBuscarUsuario();   
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioCrearUsuario.Show();

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioBuscarUsuario.Show();
        }
    }
}
