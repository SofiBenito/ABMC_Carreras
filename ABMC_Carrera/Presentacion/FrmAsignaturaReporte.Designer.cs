namespace ABMC_Carrera.Presentacion
{
    partial class FrmAsignaturaReporte
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
            this.carrerasDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrerasDataSet1 = new ABMC_Carrera.Presentacion.Reportes.CarrerasDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AsignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturaTableAdapter = new ABMC_Carrera.Presentacion.Reportes.CarrerasDataSet1TableAdapters.AsignaturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // carrerasDataSet1BindingSource
            // 
            this.carrerasDataSet1BindingSource.DataSource = this.carrerasDataSet1;
            this.carrerasDataSet1BindingSource.Position = 0;
            // 
            // carrerasDataSet1
            // 
            this.carrerasDataSet1.DataSetName = "CarrerasDataSet1";
            this.carrerasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.asignaturaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMC_Carrera.Presentacion.Reportes.RptAsignaturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // AsignaturaBindingSource
            // 
            this.AsignaturaBindingSource.DataMember = "Asignatura";
            this.AsignaturaBindingSource.DataSource = this.carrerasDataSet1;
            // 
            // asignaturaBindingSource1
            // 
            this.asignaturaBindingSource1.DataMember = "Asignatura";
            this.asignaturaBindingSource1.DataSource = this.carrerasDataSet1BindingSource;
            // 
            // asignaturaTableAdapter
            // 
            this.asignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAsignaturaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmAsignaturaReporte";
            this.Text = "FrmAsignaturaReporte";
            this.Load += new System.EventHandler(this.FrmAsignaturaReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrerasDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource carrerasDataSet1BindingSource;
        private Reportes.CarrerasDataSet1 carrerasDataSet1;
        private System.Windows.Forms.BindingSource AsignaturaBindingSource;
        private System.Windows.Forms.BindingSource asignaturaBindingSource1;
        private Reportes.CarrerasDataSet1TableAdapters.AsignaturaTableAdapter asignaturaTableAdapter;
    }
}