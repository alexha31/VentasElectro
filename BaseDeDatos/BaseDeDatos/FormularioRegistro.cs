using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos
{
    public partial class FormularioRegistro : Form
    {
        private bool estado = false;

        private ToolStripStatusLabel statusStrip;

        ErrorProvider error = new ErrorProvider();

        public FormularioRegistro(ToolStripStatusLabel usuario)
        {
            InitializeComponent();
            this.statusStrip = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration();
        }

        private void Registration()
        {

            Label_mensaje.Text = "";

            string QueryProyection = "SELECT * FROM tb_login WHERE usuario = '" + Textbox_user.Text + "' AND clave = '" + Textbox_password.Text + "';";
            
            string connectionLine = " server = 127.0.0.1; database= bd_login;port=3306;username=root;password=admin;database=bd_login;";

            if (BD_SetGet.EstablishConnection(connectionLine))
            {

                if (Textbox_user.Text == "")
                {
                    error.SetError(Textbox_user, "Rellene este campo");
                    return;
                }
                else if (Textbox_password.Text == "")
                {
                    error.SetError(Textbox_password, "Rellene este campo");
                    return;
                }

                DataTable user = BD_SetGet.ExecuteSelectCommand(QueryProyection);

                if (user.Rows.Count == 1)
                {
                    estado = true;
                    statusStrip.Text = $"Usuario conectado:  {user.Rows[0].ItemArray[0]}";
                    this.Close();
                }
                else
                {
                    Label_error.ForeColor = Color.Red;
                    Label_error.Text = "Error de autenticación: credenciales incorrectas";
                }
            }
        }

        public bool RegistrationStatus()
        {
            return estado;
        }

        private void FormularioRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!estado)
            {
                Application.Exit();
            }
        }

        private void Textbox_user_Validated(object sender, EventArgs e)
        {
            error.SetError(Textbox_user, "");   
        }

        private void Textbox_password_Validated(object sender, EventArgs e)
        {
            error.SetError(Textbox_password, "");
        }

        private void FormularioRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
