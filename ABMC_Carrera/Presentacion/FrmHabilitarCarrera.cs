using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABMC_Carrera.Datos;


namespace ABMC_Carrera.Presentacion
{
    public partial class FrmHabilitarCarrera : Form
    {
        DBHelper oBD = new DBHelper();
        public FrmHabilitarCarrera()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea salir?"
            , "SALIR"
            , MessageBoxButtons.YesNo
            , MessageBoxIcon.Question
            , MessageBoxDefaultButton.Button2)
            == DialogResult.Yes)
                Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea cancelar?"
             , "cancelando"
             , MessageBoxButtons.YesNo
             , MessageBoxIcon.Question
             , MessageBoxDefaultButton.Button2)
             == DialogResult.Yes)
                limpiar();

                
        }
        public void limpiar()
        {
            txtCarrera.Text = string.Empty;
        }

        private void FrmHabilitarCarrera_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            DataTable tabla = new DataTable();
            tabla = oBD.ConsultaSQL("pa_MostrarGrillaCuentasDeshabilitadas");
            dgbHabilitar.DataSource = tabla;
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere habilitar?", "habilitando",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCarrera.Text);
                oBD.EliminarLogico("pa_altaLogica", id);
                MessageBox.Show("se Habilito");
                cargarGrilla();
                txtCarrera.Text = "";
                

            }
        }
    }
}
