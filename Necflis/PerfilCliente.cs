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
    public partial class PerfilCliente : Form
    {
        public PerfilCliente()
        {
            InitializeComponent();
        }

        private void AbrirForm(object Nform)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            Form form = Nform as Form;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(form);
            this.pnlContenedor.Tag = form;
            form.Show();
        }

        public PerfilCliente(int id, string nombre, string direccion, string edad)
        {
            InitializeComponent();
            mostrarDatos(nombre,  direccion,  edad);
        }

        private void mostrarDatos(string nombre, string direccion, string edad)
        {
            lblNombreCliente.Text = nombre;
            lblDireccionCliente.Text = direccion;
            lblEdadCliente.Text = edad;
        }

        private void PerfilCliente_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new Playlist());
        }
    }
}
