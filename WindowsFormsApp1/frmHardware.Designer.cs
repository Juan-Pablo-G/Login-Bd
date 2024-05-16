namespace WindowsFormsApp1
{
    partial class frmHardware
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
            this.dataGridHardware = new System.Windows.Forms.DataGridView();
            this.fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProcesadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arquitectura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMemoriaFísica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHardware)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHardware
            // 
            this.dataGridHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHardware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fabricante,
            this.modelo,
            this.nombreSistema,
            this.cantidadProcesadores,
            this.arquitectura,
            this.totalMemoriaFísica});
            this.dataGridHardware.Location = new System.Drawing.Point(77, 109);
            this.dataGridHardware.Name = "dataGridHardware";
            this.dataGridHardware.Size = new System.Drawing.Size(647, 101);
            this.dataGridHardware.TabIndex = 0;
            // 
            // fabricante
            // 
            this.fabricante.HeaderText = "Fabricante";
            this.fabricante.Name = "fabricante";
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            // 
            // nombreSistema
            // 
            this.nombreSistema.HeaderText = "Nombre del sistema";
            this.nombreSistema.Name = "nombreSistema";
            // 
            // cantidadProcesadores
            // 
            this.cantidadProcesadores.HeaderText = "Cantidad de procesadores";
            this.cantidadProcesadores.Name = "cantidadProcesadores";
            // 
            // arquitectura
            // 
            this.arquitectura.HeaderText = "Arquitectura";
            this.arquitectura.Name = "arquitectura";
            // 
            // totalMemoriaFísica
            // 
            this.totalMemoriaFísica.HeaderText = "Total de memoria física";
            this.totalMemoriaFísica.Name = "totalMemoriaFísica";
            // 
            // frmHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridHardware);
            this.Name = "frmHardware";
            this.Text = "frmHardware";
            this.Load += new System.EventHandler(this.frmHardware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHardware)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHardware;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProcesadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn arquitectura;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMemoriaFísica;
    }
}