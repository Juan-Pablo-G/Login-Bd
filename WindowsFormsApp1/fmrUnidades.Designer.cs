namespace WindowsFormsApp1
{
    partial class fmrUnidades
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
            this.dataGridUnidades = new System.Windows.Forms.DataGridView();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEtiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFormato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEspacioD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEspacioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTamañoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUnidades
            // 
            this.dataGridUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaNombre,
            this.columnaEtiqueta,
            this.columnaFormato,
            this.columnaEspacioD,
            this.columnaEspacioTotal,
            this.columnaTamañoTotal});
            this.dataGridUnidades.Location = new System.Drawing.Point(53, 124);
            this.dataGridUnidades.Name = "dataGridUnidades";
            this.dataGridUnidades.Size = new System.Drawing.Size(647, 167);
            this.dataGridUnidades.TabIndex = 1;
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            // 
            // columnaEtiqueta
            // 
            this.columnaEtiqueta.HeaderText = "Etiqueta";
            this.columnaEtiqueta.Name = "columnaEtiqueta";
            // 
            // columnaFormato
            // 
            this.columnaFormato.HeaderText = "Formato";
            this.columnaFormato.Name = "columnaFormato";
            // 
            // columnaEspacioD
            // 
            this.columnaEspacioD.HeaderText = "Espacio Disponible";
            this.columnaEspacioD.Name = "columnaEspacioD";
            // 
            // columnaEspacioTotal
            // 
            this.columnaEspacioTotal.HeaderText = "Espacio total";
            this.columnaEspacioTotal.Name = "columnaEspacioTotal";
            // 
            // columnaTamañoTotal
            // 
            this.columnaTamañoTotal.HeaderText = "Tamaño total";
            this.columnaTamañoTotal.Name = "columnaTamañoTotal";
            // 
            // fmrUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridUnidades);
            this.Name = "fmrUnidades";
            this.Text = "fmrUnidades";
            this.Load += new System.EventHandler(this.fmrUnidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEtiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFormato;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEspacioD;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEspacioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTamañoTotal;
    }
}