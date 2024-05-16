using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmHardware : Form
    {
        public frmHardware()
        {
            InitializeComponent();
        }

        private void frmHardware_Load(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject d in collection)
                {
                    dataGridHardware.Rows.Add(d["Manufacturer"], d["Model"], d["Name"], d["NumberOfProcessors"], d["SystemType"], d["TotalPhysicalMemory"]);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
