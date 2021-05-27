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
    public partial class Playlist : Form
    {
        private int id_usuario;
        String conString = "datasource=localhost;port=3306;username=root;";

        public Playlist()
        {
            InitializeComponent();
        }

        public Playlist(int id)
        {
            InitializeComponent();
            this.id_usuario = id;
            LeerDataPlayList();
        }
        private void LeerDataPlayList()
        {
            string consulta = $"select * from necflis.playlist where Id_usuario = {this.id_usuario};";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand command = new MySqlCommand(consulta, con);

            try
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tblSelecCliente.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer data \n{ex}");
            }
        }

        private void LeerDataListaPelicula()
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

        private void AgregarAPlaylist(string nombre, string genero, int id_usuario)
        {
            string insert = "insert into necflis.playlist(Nombre_pelicula, Genero, Id_usuario)" +
                "VALUES ('" + nombre + "', '" + genero + "', "+id_usuario+")";

            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand command = new MySqlCommand(insert, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Agregado exitosamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar \n{ex}");
            }
        }

        private void tblSelecCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            btnVerLista.Visible = false;
            ptbPeliculas.Visible = false;
            LeerDataListaPelicula();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tblPelicula_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = tblPelicula.SelectedRows[0];
            string nombrePelicula = row.Cells[1].Value.ToString();
            string generoPelicula = row.Cells[3].Value.ToString();
            int id_usuario = this.id_usuario;

            AgregarAPlaylist(nombrePelicula, generoPelicula, id_usuario);
            LeerDataPlayList();
        }
    }
}
