using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Necflis
{
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
            LeerData();
        }

        String conString = "datasource=localhost;port=3306;username=root;";
        private void LeerData()
        {
            string consulta = "select * from necflis.cliente;";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(consulta, con);

            try
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tblCliente.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer data \n{ex}");
            }
        }
        private void ListadoClientes_Load(object sender, EventArgs e)
        {

        }

        private void tblCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
