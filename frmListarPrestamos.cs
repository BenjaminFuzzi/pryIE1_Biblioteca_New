using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIE1_Biblioteca
{
    public partial class frmListarPrestamos : Form
    {
        public frmListarPrestamos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvPrestamos.Rows.Clear();
            StreamReader leer = new StreamReader("Prestamos.txt");
            do
            {
                string Registro = leer.ReadLine();
                if (Registro != null)
                {
                    string[] campos = Registro.Split('|');
                    string titulo = DevolverTitulo(campos[1]);
                    dgvPrestamos.Rows.Add(campos[0], titulo, campos[2], campos[3], campos[4]);
                }
            } while (!leer.EndOfStream);
            leer.Close();
        }

        public string DevolverTitulo(string idLibro) {
            string titulo = "";
            StreamReader leer = new StreamReader("Libros.txt");
            do {
                string registro = leer.ReadLine();
                if (registro != null) {
                    string[] campos = registro.Split('|');
                    if (campos[0] == idLibro) {
                        return campos[1];
                    }
                }
            } while (!leer.EndOfStream);

            leer.Close();
            return titulo;
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain MainFrm = new frmMain();
            this.Hide();
            MainFrm.ShowDialog();
        }
    }
}
