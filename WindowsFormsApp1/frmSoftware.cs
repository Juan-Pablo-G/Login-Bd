using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSoftware : Form
    {
        public frmSoftware()
        {
            InitializeComponent();
        }

        private void frmSoftware_Load(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Product");

                foreach (ManagementObject d in searcher.Get())
                {
                    dataGridSoftware.Rows.Add(d["Name"]);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
