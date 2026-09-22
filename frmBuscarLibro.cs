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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace pryIE1_Biblioteca
{
    public partial class frmBuscarLibro : Form
    {
        public frmBuscarLibro()
        {
            InitializeComponent();
            CargarCBX();
        }
        

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
        }

        private void cbxCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e) {
            dgvLibros.Rows.Clear();
            StreamReader leer = new StreamReader("Libros.txt");
            do {
                string registro = leer.ReadLine();
                if (registro != null) {
                    string[] campos = registro.Split('|');
                    if (campos[1].Contains(txtNombreLibro.Text)) {
                        string categ = devolverCategoria(campos[3]);
                        dgvLibros.Rows.Add(campos[0], campos[1], campos[2], categ, campos[4]);
                    }
                }
            } while (!leer.EndOfStream);
            leer.Close();
        }
        public void CargarCBX() {
            StreamReader leer = new StreamReader("Categorias.txt");
            do {
                string registro = leer.ReadLine();
                if (registro != null)
                {
                    string[] campos = registro.Split('|');
                    cbxCateg.Items.Add(campos[1]);
                }
            } while (!leer.EndOfStream);
            leer.Close();
        }

        public string devolverCategoria(string id_cat)
        {
            string categ = "";
            StreamReader leer = new StreamReader("Categorias.txt");
            do
            {
                string registro = leer.ReadLine();
                if (registro != null)
                {
                    string[] campos = registro.Split('|');
                    if (campos[0] == id_cat)
                    {
                        return campos[1];
                    }
                }
            } while (!leer.EndOfStream);

            leer.Close();
            return categ;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvLibros.Rows.Clear();
            StreamReader leer = new StreamReader("Categorias.txt");
            StreamReader leerLibros = new StreamReader("Libros.txt");
            do
            {
                string registro = leer.ReadLine();
                if (registro != null)
                {
                    string[] campos = registro.Split('|');
                    if (campos[1].Contains(cbxCateg.Text)) {
                        do {
                            string registro2 = leerLibros.ReadLine();
                            string[] campos2 = registro2.Split('|');
                            if (campos2[3] == campos[0]) {
                                string categ = devolverCategoria(campos2[3]);
                                dgvLibros.Rows.Add(campos[0], campos2[1], campos2[2], categ, campos2[4]);
                            }
                        } while (!leerLibros.EndOfStream);
                    }
                }
            } while (!leer.EndOfStream);
            leer.Close();
            leerLibros.Close();
        }
    }
}
