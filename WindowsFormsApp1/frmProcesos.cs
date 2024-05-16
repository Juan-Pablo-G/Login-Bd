using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmProcesos : Form
    {
        public frmProcesos()
        {
            InitializeComponent();
        }

        private void frmProcesos_Load(object sender, EventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcesses();

                foreach (Process p in processes)
                {
                    string processPath = p.MainModule?.FileName ?? "Unknown";

                    dataGridProcesos.Rows.Add(p.ProcessName, p.Id, processPath);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
