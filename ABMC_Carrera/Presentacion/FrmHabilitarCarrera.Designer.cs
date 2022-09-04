namespace ABMC_Carrera.Presentacion
{
    partial class FrmHabilitarCarrera
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblCBUcuenta = new System.Windows.Forms.Label();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.dgbHabilitar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbHabilitar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(22, 251);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 36);
            this.btnSalir.TabIndex = 130;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(191, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 36);
            this.btnCancelar.TabIndex = 129;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(119, 186);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(198, 20);
            this.txtCarrera.TabIndex = 128;
            // 
            // lblCBUcuenta
            // 
            this.lblCBUcuenta.AutoSize = true;
            this.lblCBUcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBUcuenta.Location = new System.Drawing.Point(19, 186);
            this.lblCBUcuenta.Name = "lblCBUcuenta";
            this.lblCBUcuenta.Size = new System.Drawing.Size(94, 16);
            this.lblCBUcuenta.TabIndex = 127;
            this.lblCBUcuenta.Text = "CBU CUENTA";
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitar.Location = new System.Drawing.Point(78, 213);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(196, 32);
            this.btnHabilitar.TabIndex = 126;
            this.btnHabilitar.Text = "Habilitar Carrera";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // dgbHabilitar
            // 
            this.dgbHabilitar.AllowUserToAddRows = false;
            this.dgbHabilitar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbHabilitar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgbHabilitar.Location = new System.Drawing.Point(12, 12);
            this.dgbHabilitar.Name = "dgbHabilitar";
            this.dgbHabilitar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbHabilitar.Size = new System.Drawing.Size(702, 154);
            this.dgbHabilitar.TabIndex = 125;
            // 
            // FrmHabilitarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 296);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblCBUcuenta);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.dgbHabilitar);
            this.Name = "FrmHabilitarCarrera";
            this.Text = "FrmHabilitarCarrera";
            this.Load += new System.EventHandler(this.FrmHabilitarCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbHabilitar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblCBUcuenta;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.DataGridView dgbHabilitar;
    }
}