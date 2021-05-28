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

        String conString = "datasource=localhost;port=3306;username=root;";
        private void guardarPelicula()
        {
            string nombre = txtNombrePelicula.Text;
            string tipo = txtTipoPelicula.Text;
            string genero = txtGeneroPelicula.Text;
            string sinopsis = txtSinopsisPelicula.Text;

            string insert = "insert into necflis.pelicula(Nombre, Tipo, Genero, Sinopsis)" +
                "VALUES ('" + nombre + "','" + tipo + "', '" + genero + "','" + sinopsis + "')";

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(insert, con);
                con.Open();
                command.ExecuteNonQuery();
                limpiar();
                con.Close();

                MessageBox.Show("Guardado exitosamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar \n{ex}");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
