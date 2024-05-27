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
    public partial class FormGerente : Form
    {
        FormReporteGeneral formularioReporteGeneral;
        FormReportePorVendedor formularioPorVendedor;

        public FormGerente()
        {
            InitializeComponent();
            formularioReporteGeneral = new FormReporteGeneral();
            formularioPorVendedor = new FormReportePorVendedor();
        }

        private void btnRepGralVtas_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioReporteGeneral.Show();
            
        }
       
        private void btnRepVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioPorVendedor.Show();
        }
    }
}
