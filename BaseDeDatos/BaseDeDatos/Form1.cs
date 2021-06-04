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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            this.Visible = false;
            FormularioRegistro formularioRegistro = new FormularioRegistro(Label_usuario);
            formularioRegistro.ShowDialog();

            if (formularioRegistro.RegistrationStatus())
            {
                this.Visible = true;
            }
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas nuevoFormulario = new Facturas(this.facturaToolStripMenuItem);
            nuevoFormulario.MdiParent = this;
            nuevoFormulario.Dock = DockStyle.Fill;
            this.facturaToolStripMenuItem.Enabled = false;
            nuevoFormulario.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambioDeConstrasenia formulario = new CambioDeConstrasenia(this.cambiarContraseñaToolStripMenuItem);
            formulario.MdiParent = this;
            formulario.Show();
            this.cambiarContraseñaToolStripMenuItem.Enabled = false;

        }

        //lanzamiento del formulario para la edicion de el catalogo de productos
        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoProd nuevoFormulario = new CatalogoProd(this.catalogoToolStripMenuItem);
            nuevoFormulario.MdiParent = this;
            this.catalogoToolStripMenuItem.Enabled = false;
            nuevoFormulario.StartPosition = FormStartPosition.CenterParent;
            nuevoFormulario.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe nuevo = new AcercaDe(this.acercaDeToolStripMenuItem);
            nuevo.MdiParent = this;
            this.acercaDeToolStripMenuItem.Enabled = false;
            nuevo.Show();
        }
    }
}
