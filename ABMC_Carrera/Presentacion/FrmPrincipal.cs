using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABMC_Carrera.Presentacion;

namespace ABMC_Carrera
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?",
               "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaCarrera nueva = new FrmNuevaCarrera();
            nueva.ShowDialog();
        }

        private void reporteAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsignaturaReporte frmReporte = new FrmAsignaturaReporte();
            frmReporte.ShowDialog();
        }


        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCarreras frmConsultarCarreras = new FrmConsultarCarreras();
            frmConsultarCarreras.ShowDialog();
        }

     

        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void carrerasDeshabilitadasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FrmHabilitarCarrera frmHabilitarCarrera = new FrmHabilitarCarrera();
            frmHabilitarCarrera.ShowDialog();
        }

        private void reporteDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarReporteCarrera ventana = new FrmMostrarReporteCarrera();
            ventana.ShowDialog();
        }

        private void detalleAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalleAsignaturas detalleAsignaturas = new FrmDetalleAsignaturas();
            detalleAsignaturas.ShowDialog();
        }
    }
}
