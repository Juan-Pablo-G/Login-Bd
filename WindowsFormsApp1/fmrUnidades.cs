using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fmrUnidades : Form
    {
        public fmrUnidades()
        {
            InitializeComponent();
        }

        private void fmrUnidades_Load(object sender, EventArgs e)
        {
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo d in allDrives)
                {
                    dataGridUnidades.Rows.Add(d.Name, d.VolumeLabel, d.DriveFormat, d.TotalFreeSpace, d.AvailableFreeSpace, d.TotalSize);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
