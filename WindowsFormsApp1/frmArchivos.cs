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
    public partial class frmArchivos : Form
    {
        public frmArchivos()
        {
            InitializeComponent();
        }

        private void frmArchivos_Load(object sender, EventArgs e)
        {
            string directorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                if (Directory.Exists(directorio))
                {
                    string[] archivos = Directory.GetFiles(directorio);

                    foreach (string archivo in archivos)
                    {
                        FileInfo fileInfo = new FileInfo(archivo);
                        string nombreArchivo = Path.GetFileName(archivo);
                        long tamañoArchivo = fileInfo.Length;
                        string extensionArchivo = Path.GetExtension(archivo);

                        dataGridArchivos.Rows.Add(nombreArchivo, tamañoArchivo, extensionArchivo);
                    }
                }
                else
                {
                    MessageBox.Show("El directorio especificado no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener información de los archivos: " + ex.Message);
            }
        }
    }
}
