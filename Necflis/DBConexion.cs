using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Necflis
{
    class DBConexion
    {
        String conString = "datasource=localhost;port=3306;username=root;";

        public void Insert(string insert)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(insert, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Guardado exitosamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar \n{ex}");
            }
        }
    }
}
