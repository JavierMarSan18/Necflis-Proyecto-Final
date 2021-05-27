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
    public partial class ListadoPeliculas : Form
    {
        public ListadoPeliculas()
        {
            InitializeComponent();
            LeerData();
        }

        String conString = "datasource=localhost;port=3306;username=root;";
        private void LeerData()
        {
            string consulta = "select * from necflis.pelicula;";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(consulta, con);

            try
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tblPelicula.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer data \n{ex}");
            }
        }
        private void ListadoPeliculas_Load(object sender, EventArgs e)
        {

        }
    }
}
