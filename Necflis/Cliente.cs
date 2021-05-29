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
    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();
        }
        private void pnlCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.AbrirForm(pnlCliente, new ListadoClientes());
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.AbrirForm(pnlCliente, new CrearCliente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.AbrirForm(pnlCliente, new SeleccionarCliente());
        }

        private void pnlOpCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
