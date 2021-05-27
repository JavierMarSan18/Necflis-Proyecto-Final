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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        private void pnlCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirForm(object Nform)
        {
            if (this.pnlCliente.Controls.Count > 0)
                this.pnlCliente.Controls.RemoveAt(0);

            Form form = Nform as Form;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlCliente.Controls.Add(form);
            this.pnlCliente.Tag = form;
            form.Show();
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new ListadoClientes());
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new CrearCliente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new SeleccionarCliente());
        }

        private void pnlOpCliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
