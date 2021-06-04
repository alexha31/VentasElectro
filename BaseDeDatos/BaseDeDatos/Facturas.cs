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
    public partial class Facturas : Form
    {
        ToolStripMenuItem reference;//referencia hacia el objeto que lanzo a este formulario

        ErrorProvider error = new ErrorProvider();

        public Facturas(ToolStripMenuItem refMenuItem)
        {
            InitializeComponent();
            reference = refMenuItem;
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            AddItemCombo();//carga los nombres de los productos en el comboColum
            LoadTitles();//carga nombre de las columnas de datagridview
        }

        #region visualizar

        //rellena con codigos de facturas el combo visualizar
        private void AddItemCombo()
        {
            DataClasesLINQDataContext bd_cod_fac = new DataClasesLINQDataContext();

            bd_cod_fac.Connection.Open();

            //proyeccion de los codigos de las facturas para insertarlos en el ComboBox de visualizacion
            List<int> code = (from codes in bd_cod_fac.Factura
                              select codes.Codigo).ToList();

            bd_cod_fac.Connection.Close();

            //limpieza del combo
            comboVisualizar.Items.Clear();

            foreach (var item in code)
            {
                //insercion de los codigos
                comboVisualizar.Items.Add(item);
            }

            bd_cod_fac.Connection.Close();

            code.Clear();
        }

        private void Facturas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //habilitar el boton que llama a este formulario
            reference.Enabled = true;
        }

        //rellena el DataGridView visualizar
        private void CargarDataGridViewDeFacturas()
        {
            DataClasesLINQDataContext bd_data = new DataClasesLINQDataContext();

            bd_data.Connection.Open();

            double suma = 0;

            dgvVisualizar.Rows.Clear();

            foreach (var item in SelectFromProductoAndFacturaQuery(bd_data))
            {
                suma += (item.precioProducto * item.cantidadProducto);

                //carga de los datos dentro del texto multilinea
                MultiLineTextInformationLoad(item.nombreCliente, item.fechaFactura);

                //insercion de una nueva fila con los datos para cada columna
                dgvVisualizar.Rows.Add(
                    item.codigoFactura,
                    item.nombreCliente,
                    item.fechaFactura,
                    item.idProducto,
                    item.codigoProducto,
                    item.nombreProducto,
                    item.precioProducto,
                    item.cantidadProducto);

            }

            Textbox_total.Text = suma.ToString();

            bd_data.Connection.Close();
        }

        private void MultiLineTextInformationLoad(string name, string date)
        {
            MultiLineText.Text =
                    $"Nombre del cliente: {name}\r\n\r\n" +
                    $"Fecha de compra: {date}";
        }

        //Nota: msj, no disponible en C# 7.3 por ello la creacion de una clase
        private List<Persona_x_Factura> SelectFromProductoAndFacturaQuery(DataClasesLINQDataContext bd_data)
        {
            var datas = (from a in bd_data.Factura
                         join b in bd_data.Producto
                         on a.Codigo equals b.Fk_Codigo
                         where a.Codigo == int.Parse(comboVisualizar.SelectedItem.ToString())
                         select new Persona_x_Factura(
                              a.Cliente,
                              a.Codigo,
                              a.Fecha,
                              b.Id,
                              b.Codigo,
                              b.Nombre,
                              b.Precio,
                              b.Cantidad
                          )).ToList();

            return datas;
        }

        //carga los tiulos de las columnas en visualizar
        private void LoadTitles()
        {
            dgvVisualizar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisualizar.ColumnCount = 8;
            dgvVisualizar.Columns[0].Name = "Factura No.";
            dgvVisualizar.Columns[1].Name = "Cliente";
            dgvVisualizar.Columns[2].Name = "Fecha";
            dgvVisualizar.Columns[3].Name = "ID producto";
            dgvVisualizar.Columns[4].Name = "Codigo";
            dgvVisualizar.Columns[5].Name = "Nombre:";
            dgvVisualizar.Columns[6].Name = "Precio";
            dgvVisualizar.Columns[7].Name = "Cantidad";
        }
        

        private void TabPages_Selecting(object sender, TabControlCancelEventArgs e)
        {
            DataClasesLINQDataContext bd_sell = new DataClasesLINQDataContext();

            bd_sell.Connection.Open();

            if (TabPages.SelectedTab.Name.Equals("TabNueva"))
            {
                CargaComboColum(bd_sell);

                Reset();
            }
            else
            {
                //carga de los codigos de factura dentro del combo visualizar
                //en este caso funciona como actualizacion
                AddItemCombo();
                Restart();
            }

            bd_sell.Connection.Close();
        }

        private void Restart()
        {
            comboVisualizar.SelectedIndex = -1;
            dgvVisualizar.Rows.Clear();
            MultiLineText.Text = "";
        }
        #endregion


        #region NewBill
        private void Reset()
        {
            TxtFactura.Text = FindMax();
            TxtNombreDeCliente.Text = "";
            dgvNewFac.Rows.Clear();
        }

        //devuelve una lista de productos el resultado de la consulta a catalogo 
        private IEnumerable<Catalogo> ListaDeProductosCatalogo()
        {
            DataClasesLINQDataContext bd_sell = new DataClasesLINQDataContext();

            //inicio de la conexion con la base de datos MySql
            bd_sell.Connection.Open();

            //propyeccion de los elementos de la tabla catalogo
            var catalogo = from a in bd_sell.Catalogo.AsEnumerable()
                           select a;

            //cerrar la conexio a la BD
            bd_sell.Connection.Close();

            return catalogo;
        }

        //aniadir los nombres de los productos al ComboBox del DataGridView de nueva factura
        private void CargaComboColum(DataClasesLINQDataContext bd_sell)
        {
            ProductoCol.Items.Clear();

            foreach (var item in ListaDeProductosCatalogo())
            {
                ProductoCol.Items.Add(item.Nombre);
            }
        }

        //creacion de una nueva factura
        private void button1_Click(object sender, EventArgs e)
        {
            //invocacion del metodo para crear una nueva factura
            Verification();
        }

        private void Verification()
        {
            //validacion del contenido de los controles
            if (TxtFactura.Text == "")
            {
                error.SetError(TxtFactura, "Debe rellenar este campo");
                return;
            }
            else if (TxtNombreDeCliente.Text == "")
            {
                error.SetError(TxtNombreDeCliente, "Debe rellenar este campo");
                return;
            }
            if (dgvNewFac.Rows.Count - 1 == 0)
            {
                MessageBox.Show("Debe ingresar los datos del producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //metodo que crea la nueva factura
                CreateNewBill();
            }
        }

        //metodo que retorna el maximo codigo de facturas dentro de la base de datos
        private string FindMax()
        {
            DataClasesLINQDataContext bd_sell = new DataClasesLINQDataContext();

            bd_sell.Connection.Open();

            var maxCode = (from a in bd_sell.Factura select a.Codigo).Max();

            bd_sell.Connection.Close();

            return (maxCode + 1).ToString();
        }

        private void CreateNewBill()
        {
            DataClasesLINQDataContext bd_sell = new DataClasesLINQDataContext();

            bd_sell.Connection.Open();

            //query para la insercion de los elementos dentro de la tabla productos
            string queryProducto = "INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, Fk_Codigo) VALUES ({0},{1},{2},{3},{4})";

            //query para la insercion de los elementos dentro de la tabla fecha
            string queryFactura = "INSERT INTO Factura (Codigo, Cliente, Fecha) VALUES ({0}, {1}, {2})";

            int totalAffect = 0;

            bool updateFac = false;

            //seleccion de los productos en el catalogo con sus campos codigo/nombre/precio
            IEnumerable<Catalogo> catalogo = (from a in bd_sell.Catalogo.AsEnumerable() select a);

            int codigo = int.Parse(FindMax());

            string tiempo = Fecha();

            //insercion de los datos dentro de la tabla fecha 
            /*Se inserta primero la fecha porque al ingresar los datos de la tabla productos el campo FK usa PK de la
             fecha */
            bd_sell.ExecuteCommand(queryFactura, TxtFactura.Text, TxtNombreDeCliente.Text, tiempo);

            try
            {
                //recorremos cada fila del DataGridView
                //comprobar que la llave primaria no se repita de la factura no se repita
                for (int i = 0; i < dgvNewFac.Rows.Count - 1; i++)
                {
                    //comparamos el valor del ComoboBox en el datagridview con lo que tengamos en 
                    //catalogos
                    foreach (Catalogo producto in catalogo)
                    {
                        /*Comparacion del elemento Rowp[index].Cells[NameColum] con cada uno de los elementos resultado de la Query*/
                        if (string.Compare(dgvNewFac.Rows[i].Cells["ProductoCol"].Value.ToString(), producto.Nombre.ToString()) == 0)
                        {
                            try
                            {
                                /*insercion de los datos dentro de tabla producto*/
                                //se producira una excepcion de referencia no establecidad como instancia de un objeto
                                totalAffect = bd_sell.ExecuteCommand(queryProducto, producto.Codigo, producto.Nombre, producto.Precio, dgvNewFac.Rows[i].Cells["CantidadCol"].Value.ToString(), codigo);
                                updateFac = true;
                            }
                            catch (Exception error)
                            {
                                updateFac = false;
                                MessageBox.Show(error.Message, "Informacion");
                            }
                        }
                    }
                }

                if (updateFac)//si las operaciones anteriores se han realizado con exito se le confirma al usuario
                {
                    MessageBox.Show($"Factura realizada con exito\nObjetos registrados : {totalAffect}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd_sell.SubmitChanges();

                    Reset();
                }
                else
                {
                    /*Se elimina la factura recientemente ingresada si ha ocurrido algun error durante la insercion 
                      de los productos a la base de datos*/
                    bd_sell.ExecuteCommand("DELETE FROM Factura WHERE Codigo = {0}", TxtFactura.Text);
                }

            }
            catch (NullReferenceException)//excepcion que se PRODUCIA al momento de recorrer el DataGridView
            {
                MessageBox.Show("Error al guardar los elementos");
            }
        }

        //creacion de la fecha formateada  
        private string Fecha()
        {
            //objeto de tipo DateTime que adquiere el valor de la fecha seleccionada en el elemento DateTimePicker a traves de su 
            //propiedad value
            DateTime fecha = Tiempo.Value;

            Tiempo.Format = DateTimePickerFormat.Custom;

            //le indicamos el formato de presentacion de la fecha: dias de dos digitos/nombre completo del mes/año de cuatro digitos
            Tiempo.CustomFormat = "dd-MMMM-yyyy";

            string[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            try
            {
                //retorno de la cadena de texto con el formato de la fecha
                return $"{fecha.Day}-{mes[fecha.Month - 1]}-{fecha.Year}";
            }
            catch (Exception)//se producia una IndexOutOfRange Exception
            {
                MessageBox.Show("Error con formato de fecha");
                return string.Empty;
            }
        }
        #endregion

        private void TxtFactura_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtFactura, "");
        }

        private void TxtNombreDeCliente_Validated(object sender, EventArgs e)
        {
            error.SetError(TxtNombreDeCliente, "");
        }

        private void comboVisualizar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CargarDataGridViewDeFacturas();
        }

        private void TabVisualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
