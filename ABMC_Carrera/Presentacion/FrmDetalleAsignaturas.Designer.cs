namespace ABMC_Carrera.Presentacion
{
    partial class FrmDetalleAsignaturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.carrerasDataSet = new ABMC_Carrera.CarrerasDataSet();
            this.paMostrarGrupoAsignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pa_MostrarGrupoAsignaturaTableAdapter = new ABMC_Carrera.CarrerasDataSetTableAdapters.pa_MostrarGrupoAsignaturaTableAdapter();
            this.pa_MostrarGrupoAsignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carrerasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paMostrarGrupoAsignaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_MostrarGrupoAsignaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.pa_MostrarGrupoAsignaturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMC_Carrera.Presentacion.Reportes.RptAsignaturaDetalle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // carrerasDataSet
            // 
            this.carrerasDataSet.DataSetName = "CarrerasDataSet";
            this.carrerasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paMostrarGrupoAsignaturaBindingSource
            // 
            this.paMostrarGrupoAsignaturaBindingSource.DataMember = "pa_MostrarGrupoAsignatura";
            this.paMostrarGrupoAsignaturaBindingSource.DataSource = this.carrerasDataSet;
            // 
            // pa_MostrarGrupoAsignaturaTableAdapter
            // 
            this.pa_MostrarGrupoAsignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // pa_MostrarGrupoAsignaturaBindingSource
            // 
            this.pa_MostrarGrupoAsignaturaBindingSource.DataMember = "pa_MostrarGrupoAsignatura";
            this.pa_MostrarGrupoAsignaturaBindingSource.DataSource = this.carrerasDataSet;
            // 
            // FrmDetalleAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDetalleAsignaturas";
            this.Text = "FrmDetalleAsignaturas";
            this.Load += new System.EventHandler(this.FrmDetalleAsignaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrerasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paMostrarGrupoAsignaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_MostrarGrupoAsignaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CarrerasDataSet carrerasDataSet;
        private System.Windows.Forms.BindingSource paMostrarGrupoAsignaturaBindingSource;
        private CarrerasDataSetTableAdapters.pa_MostrarGrupoAsignaturaTableAdapter pa_MostrarGrupoAsignaturaTableAdapter;
        private System.Windows.Forms.BindingSource pa_MostrarGrupoAsignaturaBindingSource;
    }
}