namespace WindowsFormsApp1
{
    partial class frmSoftware
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
            this.dataGridSoftware = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSoftware)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSoftware
            // 
            this.dataGridSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSoftware.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.dataGridSoftware.Location = new System.Drawing.Point(319, 22);
            this.dataGridSoftware.Name = "dataGridSoftware";
            this.dataGridSoftware.Size = new System.Drawing.Size(166, 374);
            this.dataGridSoftware.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            // 
            // frmSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridSoftware);
            this.Name = "frmSoftware";
            this.Text = "frmSoftware";
            this.Load += new System.EventHandler(this.frmSoftware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSoftware)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSoftware;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}