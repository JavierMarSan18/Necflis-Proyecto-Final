using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Necflis
{
    class AdminForm
    {
        private Form form;

        //Abrir formulario de lista de peliculas
        public void AbrirForm(PictureBox pnlContenedor, object form)
        {
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls.RemoveAt(0);

            this.form = form as Form;

            this.form.TopLevel = false;
            this.form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(this.form);
            pnlContenedor.Tag = form;
            this.form.Show();
        }
    }
}
