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
        string consulta = "select * from necflis.cliente;";
        DBConexion leer = new DBConexion();
        public ListadoClientes()
        {
            InitializeComponent();
            leer.Select(consulta, tblCliente);
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {

        }

        private void tblCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
