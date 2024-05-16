namespace WindowsFormsApp1
{
    partial class frmProcesos
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
            this.dataGridProcesos = new System.Windows.Forms.DataGridView();
            this.nombreProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcesos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProcesos
            // 
            this.dataGridProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProceso,
            this.idProceso,
            this.rutaProceso});
            this.dataGridProcesos.Location = new System.Drawing.Point(214, 76);
            this.dataGridProcesos.Name = "dataGridProcesos";
            this.dataGridProcesos.Size = new System.Drawing.Size(342, 266);
            this.dataGridProcesos.TabIndex = 0;
            // 
            // nombreProceso
            // 
            this.nombreProceso.HeaderText = "Nombre procesos";
            this.nombreProceso.Name = "nombreProceso";
            // 
            // idProceso
            // 
            this.idProceso.HeaderText = "Id procesos";
            this.idProceso.Name = "idProceso";
            // 
            // rutaProceso
            // 
            this.rutaProceso.HeaderText = "Ruta de archivos";
            this.rutaProceso.Name = "rutaProceso";
            // 
            // frmProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridProcesos);
            this.Name = "frmProcesos";
            this.Text = "frmProcesos";
            this.Load += new System.EventHandler(this.frmProcesos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcesos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaProceso;
    }
}