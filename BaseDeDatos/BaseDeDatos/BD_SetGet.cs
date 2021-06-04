using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace BaseDeDatos
{
    class BD_SetGet
    {
        private static MySqlConnection connection;
        private static MySqlCommand command;
        private static MySqlDataAdapter adapter;

        public BD_SetGet()
        {
            connection = null;
            command = null;
            adapter = null;
        }

        //establece unicamente la conexion con el servidor usando la linea de conexion que se le proporciona 
        //nos devuelve un true en caso de que se haya realizado la operacion con exito
        //en caso contrario nos devuelve un false
        public static bool EstablishConnection(string commandLine)
        {
            try
            {
                connection = new MySqlConnection(commandLine);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /*ejecuta una query de proyeccion utilizando la conexion creada con el metodo anterior
         retornando en caso de un proceso satisfactorio una tabla con los resultados de la consulta
         que le hemos indicado a travez de su parametro ORDER*/
        public static DataTable ExecuteSelectCommand(string order)
        {
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                command = new MySqlCommand(order, connection);
                adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                connection.Close();
            }
            catch (Exception error)   
            {
                MessageBox.Show(error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return table;
        }

        /*Ejecuta una query que nos devuelve un valor entero que corresponde al total de elementos afectados*/
        public static int ExecuteOrder(string order)
        {
            int nonQ = 0;
            try
            {
                connection.Open();
                command = new MySqlCommand(order, connection);
                nonQ = command.ExecuteNonQuery();
                connection.Close(); 
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nonQ;
        }
    }
}
