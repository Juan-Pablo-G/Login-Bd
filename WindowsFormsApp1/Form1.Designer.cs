namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.infoArchivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.infoProcesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUnidades = new System.Windows.Forms.ToolStripMenuItem();
            this.infoUnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHardware = new System.Windows.Forms.ToolStripMenuItem();
            this.infoHardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.infoSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuProcesos,
            this.menuUnidades,
            this.menuHardware,
            this.menuSoftware,
            this.menuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoArchivosToolStripMenuItem});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(65, 20);
            this.menuArchivo.Text = "&Archivos";
            // 
            // infoArchivosToolStripMenuItem
            // 
            this.infoArchivosToolStripMenuItem.Name = "infoArchivosToolStripMenuItem";
            this.infoArchivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoArchivosToolStripMenuItem.Text = "Info archivos";
            this.infoArchivosToolStripMenuItem.Click += new System.EventHandler(this.infoArchivosToolStripMenuItem_Click);
            // 
            // menuProcesos
            // 
            this.menuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoProcesosToolStripMenuItem});
            this.menuProcesos.Name = "menuProcesos";
            this.menuProcesos.Size = new System.Drawing.Size(66, 20);
            this.menuProcesos.Text = "&Procesos";
            // 
            // infoProcesosToolStripMenuItem
            // 
            this.infoProcesosToolStripMenuItem.Name = "infoProcesosToolStripMenuItem";
            this.infoProcesosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoProcesosToolStripMenuItem.Text = "Info procesos";
            this.infoProcesosToolStripMenuItem.Click += new System.EventHandler(this.infoProcesosToolStripMenuItem_Click);
            // 
            // menuUnidades
            // 
            this.menuUnidades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoUnidadesToolStripMenuItem});
            this.menuUnidades.Name = "menuUnidades";
            this.menuUnidades.Size = new System.Drawing.Size(68, 20);
            this.menuUnidades.Text = "&Unidades";
            // 
            // infoUnidadesToolStripMenuItem
            // 
            this.infoUnidadesToolStripMenuItem.Name = "infoUnidadesToolStripMenuItem";
            this.infoUnidadesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.infoUnidadesToolStripMenuItem.Text = "Info unidades";
            this.infoUnidadesToolStripMenuItem.Click += new System.EventHandler(this.infoUnidadesToolStripMenuItem_Click);
            // 
            // menuHardware
            // 
            this.menuHardware.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoHardwareToolStripMenuItem});
            this.menuHardware.Name = "menuHardware";
            this.menuHardware.Size = new System.Drawing.Size(70, 20);
            this.menuHardware.Text = "&Hardware";
            // 
            // infoHardwareToolStripMenuItem
            // 
            this.infoHardwareToolStripMenuItem.Name = "infoHardwareToolStripMenuItem";
            this.infoHardwareToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.infoHardwareToolStripMenuItem.Text = "Info hardware";
            this.infoHardwareToolStripMenuItem.Click += new System.EventHandler(this.infoHardwareToolStripMenuItem_Click);
            // 
            // menuSoftware
            // 
            this.menuSoftware.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoSoftwareToolStripMenuItem});
            this.menuSoftware.Name = "menuSoftware";
            this.menuSoftware.Size = new System.Drawing.Size(65, 20);
            this.menuSoftware.Text = "&Software";
            // 
            // infoSoftwareToolStripMenuItem
            // 
            this.infoSoftwareToolStripMenuItem.Name = "infoSoftwareToolStripMenuItem";
            this.infoSoftwareToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.infoSoftwareToolStripMenuItem.Text = "Info software";
            this.infoSoftwareToolStripMenuItem.Click += new System.EventHandler(this.infoSoftwareToolStripMenuItem_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "A&yuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuProcesos;
        private System.Windows.Forms.ToolStripMenuItem menuUnidades;
        private System.Windows.Forms.ToolStripMenuItem menuHardware;
        private System.Windows.Forms.ToolStripMenuItem menuSoftware;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoUnidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoHardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoArchivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoProcesosToolStripMenuItem;
    }
}

