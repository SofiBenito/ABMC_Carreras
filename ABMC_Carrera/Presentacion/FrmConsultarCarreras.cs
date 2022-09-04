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
using ABMC_Carrera.Dominio;
using System.Data.SqlClient;

namespace ABMC_Carrera.Presentacion
{
    public partial class FrmConsultarCarreras : Form
    {
        DBHelper oBD = new DBHelper();
        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=Carreras;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();    
        public FrmConsultarCarreras()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?",
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void FrmConsultarCarreras_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cargarCombo();
            cboCarrera.SelectedIndex = -1;
        }
        private void cargarGrilla()
        {
            DataTable tabla = new DataTable();
            tabla = oBD.ConsultaSQL("pa_MostrarDetalleConsulta");
            dgvConsultas.DataSource = tabla;
          

        }

        private DataTable cargarCombo()
        {
            DataTable dt = new DataTable();
            dt = oBD.ConsultaSQL("pa_CargarComboCarrera");
            cboCarrera.DataSource = dt;
            cboCarrera.ValueMember = "idCarrera";
            cboCarrera.DisplayMember = "nombre";
            return dt;

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere deshabilitar?", "Deshabilitando",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                int id=Convert.ToInt32(txtDeshabilitar.Text);
                oBD.EliminarLogico("pa_BajaLogica", id);
                MessageBox.Show("se Desabilito");
                cargarGrilla();
                txtDeshabilitar.Text = "";
                cboCarrera.SelectedIndex = -1;

            }
        }

        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarfiltroCombo();
            
        }

        private DataTable cargarfiltroCombo()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select idDetalle,dc.idCarrera,c.nombre,a.nombre Asignatura,anioCursado,cuatrimestre,Activo from detalleCarrera as dc join carrera as c on dc.idCarrera=c.idCarrera join Asignatura as a on a.idAsignatura=dc.idAsignatura WHERE Activo=1 and c.nombre=  '" + cboCarrera.Text.ToString() + "'";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            dgvConsultas.DataSource = dt;
            return dt;
        }

   
    }
}
