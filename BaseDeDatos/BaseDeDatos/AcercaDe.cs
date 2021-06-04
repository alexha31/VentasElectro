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
    public partial class AcercaDe : Form
    {
        ToolStripMenuItem reff;

        public AcercaDe(ToolStripMenuItem control)
        {
            InitializeComponent();
            reff = control;
        }

        private void AcercaDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            reff.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
