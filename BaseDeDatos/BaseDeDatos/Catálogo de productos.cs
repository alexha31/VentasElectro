using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaseDeDatos
{
    public partial class CatalogoProd : Form
    {
        ToolStripMenuItem refr;

        DataSet dataColection = new DataSet();

        SqlConnection conection;


        SqlDataAdapter adaptador;

        SqlCommand comando;

        public CatalogoProd(ToolStripMenuItem refr)
        {
            InitializeComponent();

            this.refr = refr;
        }

        private void Catálogo_de_productos_Load(object sender, EventArgs e)
        {
            SelectQuery();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = dataColection.Tables["Catalogo"];
        }

        private void Catalogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            refr.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                adaptador.Update(dataColection, "Catalogo");

                dataColection.AcceptChanges();

                MessageBox.Show("Cambios realizados","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectQuery()
        {
            //instacia de un nuevo objeto SqlDataAdapter que necesita de un objeto command
            //comand ya tiene asociado una conexion y una consulta SQL
            adaptador = new SqlDataAdapter();

            //linea de comando para realizar la conexion a la base de datos
            string ConnectionLine = @"Data Source=MSI-GL638RD\SQLEXPRESS01;Initial Catalog=bd_ventas;Integrated Security=True";

            //linea sql para la proyeccion de los datos de la tabla
            string selectionQuery = "select * from catalogo";

            //creacion de un nuevo objeto SqlConexion con una linea de conexion
             conection = new SqlConnection(ConnectionLine);

            //creacion del objeto SqlCommand que sera para la seleccion de datos que usara el metodo Fill
            //esto llenara el DataSet o el DataTable, segun se quiera usar
            #region Creacion del comando de seleccion
            comando = new SqlCommand();
            comando.Connection = conection;
            comando.CommandText = selectionQuery;
            adaptador.SelectCommand = comando;
            #endregion

            //creacion de los SqlCommand para las operaciones de insercion, eliminacion y actualizacion dentro del origen de datos
            #region Creacion del comando de insercion
            comando = new SqlCommand("INSERT INTO Catalogo(codigo, nombre, precio) VALUES (@codigo, @name, @price)", conection);
            comando.Parameters.Add("@codigo", SqlDbType.Int, 4, "codigo");
            comando.Parameters.Add("@name", SqlDbType.VarChar, 100, "nombre");
            comando.Parameters.Add("@price", SqlDbType.Float, 8, "precio"); 
            adaptador.InsertCommand = comando;
            #endregion

            #region Creacion del comando de eliminacion
            comando = new SqlCommand("DELETE FROM Catalogo WHERE codigo = @codigo", conection);
            comando.Parameters.Add("@codigo", SqlDbType.Int, 4, "codigo");
            adaptador.DeleteCommand = comando;
            #endregion

            #region Creacion del comando de actualizacion
            comando = new SqlCommand("UPDATE Catalogo SET codigo = @codigo, nombre = @nombre, precio = @precio WHERE codigo = @codigoViejo", conection);
            comando.Parameters.Add("@codigo", SqlDbType.Int, 4, "codigo");
            comando.Parameters.Add("@nombre", SqlDbType.VarChar, 100, "nombre");
            comando.Parameters.Add("@precio", SqlDbType.Float, 8, "precio");
            SqlParameter oldcod = comando.Parameters.Add("@codigoViejo", SqlDbType.Int, 4, "codigo");
            oldcod.SourceVersion = DataRowVersion.Original;
            adaptador.UpdateCommand = comando;
            #endregion

            //llenado del DataSet con el resultado de selectionQuery
            adaptador.Fill(dataColection,"Catalogo");
        }

        private void CatalogoProd_Resize_1(object sender, EventArgs e)
        {
            if (this.Width < 550)
            {
                groupBox1.Text = "Realice cualqier edicion sobre la tabla:";
                button1.Location = new Point(140, 347);
            }
            else
            {
                groupBox1.Text = "Realice las operaciones de inserción, actualización y eliminación de productos sobre la tabla:";
                button1.Location = new Point(335, 349);
            }
        }
    }
}
