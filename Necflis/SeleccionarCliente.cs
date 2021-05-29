using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Necflis
{
    public partial class SeleccionarCliente : Form
    {
        public SeleccionarCliente()
        {
            InitializeComponent();
            LeerData();
        }

        private void LeerData()
        {
            string consulta = "select * from necflis.cliente;";
            DBConexion leer = new DBConexion();
            leer.Select(consulta, tblSelecCliente);
        }

        private void tblSelecCliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = tblSelecCliente.SelectedRows[0];
            cCliente cliente = new cCliente(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), int.Parse(row.Cells[3].Value.ToString()));

            PerfilCliente perfil = new PerfilCliente(cliente.id, cliente.nombre, cliente.direccion, cliente.edad.ToString());
            perfil.Show();
        }

        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {

        }

        private void tblSelecCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
