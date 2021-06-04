using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BaseDeDatos
{
    public partial class CambioDeConstrasenia : Form
    {
        ToolStripMenuItem obj;

        ErrorProvider errorProvider = new ErrorProvider();

        public CambioDeConstrasenia(ToolStripMenuItem botonPassChange)
        {
            InitializeComponent();
            obj = botonPassChange;
        }

        private void CambioDeConstrasenia_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionLine = "server = 127.0.0.1; database= bd_login;port=3306;username=root;password=admin;database=bd_login;";

            if (BD_SetGet.EstablishConnection(connectionLine))
            {
                if (TxtNowPass.Text == "")
                {
                    errorProvider.SetError(TxtNowPass,"Escribe tu contraseña actual");
                    return;
                }
                else if (TxtNewPass.Text == "")
                {
                    errorProvider.SetError(TxtNewPass, "Escribe tu nueva contraseña");
                    return;
                }
                else if (TxtNewPassConfirm.Text == "")
                {
                    errorProvider.SetError(TxtNewPassConfirm, "Confirma la nueva contraseña");
                    return;
                }
                else if (string.Compare(TxtNewPass.Text, TxtNewPassConfirm.Text) != 0)
                {
                    errorProvider.SetError(TxtNewPass, "Las contraeñas no coinciden");
                    errorProvider.SetError(TxtNewPassConfirm, "Las contraeñas no coinciden");
                    return;
                }

                var datos = SearchPass(TxtNowPass.Text);

                bool state = false;
                
                foreach (var item in datos)
                {
                    //comprueba si la contraseña actual ingresada es correcta
                    if (item.ItemArray[2].ToString().Equals(TxtNowPass.Text))
                    {
                        //Se realiza la actualizacion de la contraseña
                        if (CambiaContraseña(TxtNowPass.Text, TxtNewPass.Text))
                        {
                            state = true;
                        }
                        else
                            return;
                    }
                }

                if (state == false)
                {   
                    errorProvider.SetError(TxtNowPass, "Contraseña incorrecta");
                    return;
                }
                else
                {
                    this.Close();
                }

            }
        }

        private bool CambiaContraseña(string Oldpass, string newPass)
        {

            string commandUpdate = "UPDATE tb_login SET clave = '" + TxtNewPass.Text + "' WHERE clave = '" + TxtNowPass.Text + "';";

            //confirma si la contrasenia nueva es parecida a la antigua
            if (string.Compare(Oldpass, newPass) != 0)
            {
                BD_SetGet.ExecuteOrder(commandUpdate);

                MessageBox.Show("Contraseña se cambio con exito", "Estado de la operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ingresa una contraseña totalmente nueva");
                return false;
            }

        }

        private IEnumerable<DataRow> SearchPass(string pass)
        {
            string commandLine = "SELECT * FROM tb_login";

            DataTable dt = BD_SetGet.ExecuteSelectCommand(commandLine);
            

            IEnumerable < DataRow > data = from a in dt.AsEnumerable() select a;

            return data;
            
        }

        #region Validacion de botones
        private void TxtNowPass_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(TxtNowPass, "");
        }

        private void TxtNewPass_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(TxtNewPass, "");
        }

        private void TxtNewPassConfirm_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(TxtNewPassConfirm, "");
        }

        #endregion

        private void CambioDeConstrasenia_Load(object sender, EventArgs e)
        {

        }
    }
}
