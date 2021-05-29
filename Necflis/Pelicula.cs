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

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.AbrirForm(pnlPelicula, new ListadoPeliculas());
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.AbrirForm(pnlPelicula, new CrearPelicula());
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
