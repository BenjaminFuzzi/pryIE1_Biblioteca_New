using Microsoft.Win32;
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
    public partial class frmListarLibros : Form
    {
        public frmListarLibros()
        {
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain MainFrm = new frmMain();
            this.Hide();
            MainFrm.ShowDialog();
            
        }

        private void btnConsultar_Click(object sender, EventArgs e) {
            dgvLibros.Rows.Clear();
            StreamReader leer = new StreamReader("Libros.txt");
            do {
                string Registro = leer.ReadLine();
                if (Registro != null) {
                    string[] campos = Registro.Split('|');
                    string categ = devolverCategoria(campos[3]);
                    dgvLibros.Rows.Add(campos[0], campos[1], campos[2], categ, campos[4]);
                }
            } while(!leer.EndOfStream);
            leer.Close();
        }

        public string devolverCategoria(string id_cat)
        {
            string categ = "";
            StreamReader leer = new StreamReader("Categorias.txt");
            do {
                string registro = leer.ReadLine();
                if (registro != null) {
                    string[] campos = registro.Split('|');
                    if (campos[0] == id_cat) {
                        return campos[1];
                    }
                }
            } while (!leer.EndOfStream);

            leer.Close();
            return categ;
        }


    }
}
