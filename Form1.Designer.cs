namespace pryIE1_Biblioteca
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPréstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPréstamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePréstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarLibrosToolStripMenuItem,
            this.buscarLibroToolStripMenuItem,
            this.nuevoLibroToolStripMenuItem});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // listarLibrosToolStripMenuItem
            // 
            this.listarLibrosToolStripMenuItem.Name = "listarLibrosToolStripMenuItem";
            this.listarLibrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarLibrosToolStripMenuItem.Text = "Listar libros";
            this.listarLibrosToolStripMenuItem.Click += new System.EventHandler(this.listarLibrosToolStripMenuItem_Click);
            // 
            // buscarLibroToolStripMenuItem
            // 
            this.buscarLibroToolStripMenuItem.Name = "buscarLibroToolStripMenuItem";
            this.buscarLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarLibroToolStripMenuItem.Text = "Buscar libro";
            this.buscarLibroToolStripMenuItem.Click += new System.EventHandler(this.buscarLibroToolStripMenuItem_Click);
            // 
            // nuevoLibroToolStripMenuItem
            // 
            this.nuevoLibroToolStripMenuItem.Name = "nuevoLibroToolStripMenuItem";
            this.nuevoLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoLibroToolStripMenuItem.Text = "Nuevo libro";
            this.nuevoLibroToolStripMenuItem.Click += new System.EventHandler(this.nuevoLibroToolStripMenuItem_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarPréstamosToolStripMenuItem,
            this.nuevoPréstamoToolStripMenuItem});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // listarPréstamosToolStripMenuItem
            // 
            this.listarPréstamosToolStripMenuItem.Name = "listarPréstamosToolStripMenuItem";
            this.listarPréstamosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarPréstamosToolStripMenuItem.Text = "Listar préstamos";
            // 
            // nuevoPréstamoToolStripMenuItem
            // 
            this.nuevoPréstamoToolStripMenuItem.Name = "nuevoPréstamoToolStripMenuItem";
            this.nuevoPréstamoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoPréstamoToolStripMenuItem.Text = "Nuevo préstamo";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeCategoríasToolStripMenuItem,
            this.listadoDeLibrosToolStripMenuItem,
            this.listadoDePréstamosToolStripMenuItem,
            this.estadísticasToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // listadoDeCategoríasToolStripMenuItem
            // 
            this.listadoDeCategoríasToolStripMenuItem.Name = "listadoDeCategoríasToolStripMenuItem";
            this.listadoDeCategoríasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listadoDeCategoríasToolStripMenuItem.Text = "Listado de categorías";
            // 
            // listadoDeLibrosToolStripMenuItem
            // 
            this.listadoDeLibrosToolStripMenuItem.Name = "listadoDeLibrosToolStripMenuItem";
            this.listadoDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listadoDeLibrosToolStripMenuItem.Text = "Listado de libros";
            // 
            // listadoDePréstamosToolStripMenuItem
            // 
            this.listadoDePréstamosToolStripMenuItem.Name = "listadoDePréstamosToolStripMenuItem";
            this.listadoDePréstamosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listadoDePréstamosToolStripMenuItem.Text = "Listado de préstamos";
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 204);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPréstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPréstamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePréstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

