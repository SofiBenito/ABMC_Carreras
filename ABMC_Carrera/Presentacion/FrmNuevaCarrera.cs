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

namespace ABMC_Carrera.Presentacion
{
    public partial class FrmNuevaCarrera : Form
    {
        DBHelper oBD = new DBHelper();
        Carrera oCarrera = new Carrera();
        public FrmNuevaCarrera()
        {
            InitializeComponent();
        }
        private void FrmNuevaCarrera_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        private DataTable cargarCombo()
        {
            DataTable tabla = new DataTable();
            tabla = oBD.ConsultaSQL("pa_cargarCombo");
            cboMateria.DataSource = tabla;
            cboMateria.ValueMember = "idAsignatura";
            cboMateria.DisplayMember = "nombre";
            return tabla;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?",
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la carrera", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboMateria.SelectedItem.Equals(String.Empty))
            {
                MessageBox.Show("seleccione una materia", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAnioCursado.Text == "")
            {
                MessageBox.Show("Debe ingresar un año de cursado", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!rbnPrimerCuatrimestre.Checked && !rbnSegundoCuatrimestre.Checked)
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre", "Atención",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DetalleCarrera dc in oCarrera.DetallesCarrera)
            {
                if (dc.Materia.Nombre == cboMateria.Text)
                {
                    MessageBox.Show("Solo puede agregar una vez cada materia", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            Asignatura asignatura = new Asignatura();
            asignatura.IdAsignatura = Convert.ToInt32(cboMateria.SelectedValue);
            asignatura.Nombre = cboMateria.Text;
            int anioCursado = int.Parse(txtAnioCursado.Text);
            int cuatrimestre = 0;
            if (rbnPrimerCuatrimestre.Checked) cuatrimestre = 1;
            if (rbnSegundoCuatrimestre.Checked) cuatrimestre = 2;

            DetalleCarrera detCarrera = new DetalleCarrera(anioCursado, cuatrimestre, asignatura);
            oCarrera.AgregarDetalle(detCarrera);
            dgvDetalles.Rows.Add(new Object[] { asignatura.IdAsignatura, asignatura.Nombre, anioCursado, cuatrimestre });
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                if (MessageBox.Show("¿Desea quitar el detalle?",
                    "Quitar Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oCarrera.EliminarDetalle(dgvDetalles.CurrentCell.RowIndex);
                    dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                }
            }
        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            oCarrera.Nombre_Titulo = txtNombreCarrera.Text;
        }
        private void guardarCarrera()
        {
            oCarrera.Nombre_Titulo = txtNombreCarrera.Text;
            if (oBD.confirmarCarrera(oCarrera))
            {
                MessageBox.Show("Carrera registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la Carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           if(txtNombreCarrera.Text==string.Empty)
           {
                MessageBox.Show("Debe ingresar un cliente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
           }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            guardarCarrera();
        }
    }
}
