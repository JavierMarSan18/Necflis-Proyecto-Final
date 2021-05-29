﻿using MySql.Data.MySqlClient;
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
        cCliente cliente;
        DBConexion conexion = new DBConexion();

        public Playlist()
        {
            InitializeComponent();
        }

        public Playlist(int id)
        {
            InitializeComponent();
            cliente = new cCliente(id);
            LeerDataPlayList();
        }
        private void LeerDataPlayList()
        {
            string consulta = $"select * from necflis.playlist where Id_usuario = {cliente.id};";
            conexion.Select(consulta, tblSelecCliente);
        }

        private void AgregarAPlaylist(string nombre, string genero)
        {
            string insert = "insert into necflis.playlist(Nombre_pelicula, Genero, Id_usuario)" +
                "VALUES ('" + nombre + "', '" + genero + "', "+ cliente.id +")";

            conexion.Insert(insert);
        }

        private void tblSelecCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            btnVerLista.Visible = false;
            ptbPeliculas.Visible = false;

            string consulta = $"select * from necflis.pelicula;";
            conexion.Select(consulta, tblPelicula);
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
            cPelicula pelicula = new cPelicula(row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString());

            AgregarAPlaylist(pelicula.nombre, pelicula.genero);
            LeerDataPlayList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
