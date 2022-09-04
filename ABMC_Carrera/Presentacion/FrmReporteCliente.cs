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
    public partial class FrmReporteCliente : Form
    {
        public FrmReporteCliente()
        {
            InitializeComponent();
        }
        public int Carrera { get; set; }
        private void FrmReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetClientesDetalle.paReporteCarreraDetalle' Puede moverla o quitarla según sea necesario.
            this.paReporteCarreraDetalleTableAdapter.Fill(this.datasetClientesDetalle.paReporteCarreraDetalle,Carrera);
            // TODO: esta línea de código carga datos en la tabla 'datasetClientesDetalle.paReporteCarreraDetalle' Puede moverla o quitarla según sea necesario.


            this.reportViewer1.RefreshReport();
        }
    }
}
