using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABMC_Carrera.Presentacion.Reportes;

namespace ABMC_Carrera.Presentacion
{
    public partial class FrmMostrarReporteCarrera : Form
    {
        public FrmMostrarReporteCarrera()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteCliente reporteCliente = new FrmReporteCliente();
            reporteCliente.Carrera = Convert.ToInt32(txtCarrera.Text);
            reporteCliente.ShowDialog();
        }

        private void FrmMostrarReporteCarrera_Load(object sender, EventArgs e)
        {

        }
    }
}
