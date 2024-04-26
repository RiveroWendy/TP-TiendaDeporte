using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeraApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = tboxUser.Text;
            string password = tboxPass.Text;

            bll.Login unLogin = new bll.Login(usuario,password);

            if(unLogin.iniciarSesion())
            {
                MessageBox.Show("Inicio de Sesion Exitoso");
            }
            else
            {
                MessageBox.Show("Datos ingresados son invalidos");
            }

        }

        private void tboxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
