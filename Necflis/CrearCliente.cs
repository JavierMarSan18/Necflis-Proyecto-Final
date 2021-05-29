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
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtNombreCliente.Text = String.Empty;
            txtDireccionCliente.Text = String.Empty;
        }

        private void guardarCliente()
        {
            cCliente cliente = new cCliente(txtNombreCliente.Text, txtDireccionCliente.Text, int.Parse(txtEdadCliente.Text));

            string insert = "insert into necflis.cliente(Nombre, Direccion, Edad)" + 
                "VALUES ('"+ cliente.nombre + "','" + cliente.direccion + "', " + cliente.edad + ")";

            DBConexion agregar = new DBConexion();
            agregar.Insert(insert);
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardarCliente();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdadCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
