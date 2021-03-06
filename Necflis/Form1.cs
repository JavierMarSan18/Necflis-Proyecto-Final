using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Necflis
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPelicula_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Azucena López\t0907-20-11489\n" +
                             "Osman Cordero\t0907-20-6641\n" +
                             "Billy Cardona\t0907-20-15738\n" +
                             "Javier Marroquín\t0907-20-22352\n" +
                             "Humberto Duarte\t0907-20-10607";
            MessageBox.Show(message);
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.AbrirForm(pnlContenedor, new formCliente());
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.AbrirForm(pnlContenedor, new formPelicula());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
