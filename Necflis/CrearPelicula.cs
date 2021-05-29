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
    public partial class CrearPelicula : Form
    {
        public CrearPelicula()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtNombrePelicula.Text = String.Empty;
            txtSinopsisPelicula.Text = String.Empty;
        }

        private void guardarPelicula()
        {
            cPelicula pelicula = new cPelicula(txtNombrePelicula.Text, txtTipoPelicula.Text, txtGeneroPelicula.Text, txtSinopsisPelicula.Text);

            string insert = "insert into necflis.pelicula(Nombre, Tipo, Genero, Sinopsis)" +
                "VALUES ('" + pelicula.nombre + "','" + pelicula.tipo + "', '" + pelicula.genero + "','" + pelicula.sinopsis + "')";

            DBConexion agregar = new DBConexion();
            agregar.Insert(insert);
            limpiar();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrearPelicula_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            guardarPelicula();
        }

        private void txtNombrePelicula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
