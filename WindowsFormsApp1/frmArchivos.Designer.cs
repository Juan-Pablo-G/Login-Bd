namespace WindowsFormsApp1
{
    partial class frmArchivos
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
            this.dataGridArchivos = new System.Windows.Forms.DataGridView();
            this.nombreArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamañoArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionArchivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridArchivos
            // 
            this.dataGridArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreArchivo,
            this.tamañoArchivo,
            this.extensionArchivos});
            this.dataGridArchivos.Location = new System.Drawing.Point(236, 33);
            this.dataGridArchivos.Name = "dataGridArchivos";
            this.dataGridArchivos.Size = new System.Drawing.Size(346, 384);
            this.dataGridArchivos.TabIndex = 1;
            // 
            // nombreArchivo
            // 
            this.nombreArchivo.HeaderText = "Nombre archivos";
            this.nombreArchivo.Name = "nombreArchivo";
            // 
            // tamañoArchivo
            // 
            this.tamañoArchivo.HeaderText = "Tamaño archivos";
            this.tamañoArchivo.Name = "tamañoArchivo";
            // 
            // extensionArchivos
            // 
            this.extensionArchivos.HeaderText = "Extension archivos";
            this.extensionArchivos.Name = "extensionArchivos";
            // 
            // frmArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridArchivos);
            this.Name = "frmArchivos";
            this.Text = "frmArchivos";
            this.Load += new System.EventHandler(this.frmArchivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArchivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridArchivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamañoArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionArchivos;
    }
}