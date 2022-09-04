using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC_Carrera.Presentacion
{
    public partial class FrmAsignaturaReporte : Form
    {
        public FrmAsignaturaReporte()
        {
            InitializeComponent();
        }

        private void FrmAsignaturaReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carrerasDataSet1.Asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.carrerasDataSet1.Asignatura);

            this.reportViewer1.RefreshReport();
        }
    }
}
