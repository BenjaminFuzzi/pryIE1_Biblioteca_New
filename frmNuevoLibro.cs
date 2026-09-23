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
    public partial class frmNuevoLibro : Form
    {
        public frmNuevoLibro()
        {
            InitializeComponent();
            CargarCBX();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void CargarCBX()
        {
            StreamReader leer = new StreamReader("Categorias.txt");
            do
            {
                string registro = leer.ReadLine();
                if (registro != null)
                {
                    string[] campos = registro.Split('|');
                    cbxCategoria.Items.Add(campos[1]);
                }
            } while (!leer.EndOfStream);
            leer.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text != string.Empty && txtAutor.Text != string.Empty && txtCant.Text != string.Empty && Int32.TryParse(txtCant.Text, out Int32 y) && cbxCategoria.Text != string.Empty) {
                StreamReader leer = new StreamReader("Libros.txt");
                Int32 lastID;
                do
                {
                    String registro = leer.ReadLine();
                    string[] campos = registro.Split('|');
                    lastID = Convert.ToInt32(campos[0]);
                } while (!leer.EndOfStream);
                leer.Close();

                StreamReader leerCateg = new StreamReader("Categorias.txt");
                Int32 CategID = 0;
                do
                {
                    String registroCateg = leerCateg.ReadLine();
                    string[] camposCateg = registroCateg.Split('|');
                    if (camposCateg[1] == cbxCategoria.Text)
                    {
                        CategID = Convert.ToInt32(camposCateg[0]);
                    }
                } while (!leerCateg.EndOfStream);
                leerCateg.Close();

                StreamWriter Agregar = new StreamWriter("libros.txt", true);
                String ID = (lastID + 1).ToString();
                String cID = (CategID).ToString();
                Agregar.WriteLine(ID + '|' + txtTitulo.Text + '|' + txtAutor.Text + '|' + cID + '|' + txtCant.Text);
                Agregar.Close();
                MessageBox.Show("Libro agregado", "Libros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Ingresar datos válidos", "Libros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }
    }
}
