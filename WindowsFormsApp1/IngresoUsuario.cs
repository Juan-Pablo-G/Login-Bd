using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IngresoUsuario : Form
    {
        private int intentosRestantes = 3;
        private bool mensajeErrorMostrado = false;

        public IngresoUsuario()
        {
            InitializeComponent();
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            txtContraseña.KeyPress += txtContraseña_KeyPress;
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (ValidateUser(usuario, contraseña))
            {
                Form1 menuPrincipal = new Form1();
                menuPrincipal.ShowDialog();
                this.Dispose();
            }
            else
            {
                if (!mensajeErrorMostrado)
                {
                    intentosRestantes--;
                    if (intentosRestantes > 0)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos. Intentos restantes: " + intentosRestantes, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mensajeErrorMostrado = true;
                    }
                    else
                    {
                        MessageBox.Show("Se han agotado los intentos. La aplicación se cerrará.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                else
                {
                    mensajeErrorMostrado = false;
                }
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }

        private bool ValidateUser(string username, string password)
        {
            bool isValid = false;
            string connectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.DbInicioSesionConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(1) FROM Usuarios WHERE NombreUsuario=@username AND Contrasena=@password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 1)
                    {
                        isValid = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return isValid;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIniciar.PerformClick();
            }
        }
    }
}
