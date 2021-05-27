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
    public partial class FormPelicula : Form
    {
        public FormPelicula()
        {
            InitializeComponent();
        }

        private void AbrirForm(object Nform)
        {
            if (this.pnlPelicula.Controls.Count > 0)
                this.pnlPelicula.Controls.RemoveAt(0);

            Form form = Nform as Form;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlPelicula.Controls.Add(form);
            this.pnlPelicula.Tag = form;
            form.Show();
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new ListadoPeliculas());
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new CrearPelicula());
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
