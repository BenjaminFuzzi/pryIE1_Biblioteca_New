using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIE1_Biblioteca
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmListarLibros ListarLibros = new frmListarLibros();
        frmBuscarLibro BuscarLibro = new frmBuscarLibro();
        frmNuevoLibro NuevoLibro = new frmNuevoLibro();
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarLibros.Show();
            this.Hide();
        }

        private void buscarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarLibro.Show();
            this.Hide();
        }

        private void nuevoLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoLibro.Show();
            this.Hide();
        }
    }
}
