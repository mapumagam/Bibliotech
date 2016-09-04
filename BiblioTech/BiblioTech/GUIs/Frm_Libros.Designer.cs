namespace BiblioTech.GUIs
{
    partial class Frm_Libros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEdicion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAnio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.cmCatalogosAU = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiNuevoAU = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiAbrirAU = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.cmCatalogosED = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiNuevoED = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiAbrirED = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmCatalogosAR = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiNuevaAR = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiAbrirAR = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbEjemplares = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.cmCatalogosAU.SuspendLayout();
            this.cmCatalogosED.SuspendLayout();
            this.cmCatalogosAR.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave del libro:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(834, 40);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Libros";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbClave
            // 
            this.txbClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbClave.Enabled = false;
            this.txbClave.Location = new System.Drawing.Point(254, 75);
            this.txbClave.Name = "txbClave";
            this.txbClave.Size = new System.Drawing.Size(152, 26);
            this.txbClave.TabIndex = 19;
            // 
            // txbTitulo
            // 
            this.txbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTitulo.Enabled = false;
            this.txbTitulo.Location = new System.Drawing.Point(254, 107);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(447, 26);
            this.txbTitulo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Editorial:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Área:";
            // 
            // txbEdicion
            // 
            this.txbEdicion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbEdicion.Enabled = false;
            this.txbEdicion.Location = new System.Drawing.Point(254, 235);
            this.txbEdicion.Name = "txbEdicion";
            this.txbEdicion.Size = new System.Drawing.Size(354, 26);
            this.txbEdicion.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Edición:";
            // 
            // txbAnio
            // 
            this.txbAnio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbAnio.Enabled = false;
            this.txbAnio.Location = new System.Drawing.Point(254, 267);
            this.txbAnio.Name = "txbAnio";
            this.txbAnio.Size = new System.Drawing.Size(70, 26);
            this.txbAnio.TabIndex = 31;
            this.txbAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAnio_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(209, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Año:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Numero de ejemplares:";
            // 
            // cmbAutor
            // 
            this.cmbAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAutor.ContextMenuStrip = this.cmCatalogosAU;
            this.cmbAutor.Enabled = false;
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(254, 139);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(447, 26);
            this.cmbAutor.TabIndex = 34;
            // 
            // cmCatalogosAU
            // 
            this.cmCatalogosAU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiNuevoAU,
            this.cmiAbrirAU});
            this.cmCatalogosAU.Name = "contextMenuStrip1";
            this.cmCatalogosAU.Size = new System.Drawing.Size(119, 48);
            // 
            // cmiNuevoAU
            // 
            this.cmiNuevoAU.Name = "cmiNuevoAU";
            this.cmiNuevoAU.Size = new System.Drawing.Size(118, 22);
            this.cmiNuevoAU.Text = "Nuevo...";
            this.cmiNuevoAU.Click += new System.EventHandler(this.cmiNuevoAU_Click);
            // 
            // cmiAbrirAU
            // 
            this.cmiAbrirAU.Name = "cmiAbrirAU";
            this.cmiAbrirAU.Size = new System.Drawing.Size(118, 22);
            this.cmiAbrirAU.Text = "Abrir...";
            this.cmiAbrirAU.Click += new System.EventHandler(this.cmiAbrirAU_Click);
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEditorial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEditorial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEditorial.ContextMenuStrip = this.cmCatalogosED;
            this.cmbEditorial.Enabled = false;
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(254, 171);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(447, 26);
            this.cmbEditorial.TabIndex = 35;
            // 
            // cmCatalogosED
            // 
            this.cmCatalogosED.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiNuevoED,
            this.cmiAbrirED});
            this.cmCatalogosED.Name = "contextMenuStrip1";
            this.cmCatalogosED.Size = new System.Drawing.Size(119, 48);
            // 
            // cmiNuevoED
            // 
            this.cmiNuevoED.Name = "cmiNuevoED";
            this.cmiNuevoED.Size = new System.Drawing.Size(118, 22);
            this.cmiNuevoED.Text = "Nuevo...";
            this.cmiNuevoED.Click += new System.EventHandler(this.cmiNuevo_Click);
            // 
            // cmiAbrirED
            // 
            this.cmiAbrirED.Name = "cmiAbrirED";
            this.cmiAbrirED.Size = new System.Drawing.Size(118, 22);
            this.cmiAbrirED.Text = "Abrir...";
            this.cmiAbrirED.Click += new System.EventHandler(this.cmiAbrir_Click);
            // 
            // cmbArea
            // 
            this.cmbArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArea.ContextMenuStrip = this.cmCatalogosAR;
            this.cmbArea.Enabled = false;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(254, 203);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(447, 26);
            this.cmbArea.TabIndex = 36;
            // 
            // cmCatalogosAR
            // 
            this.cmCatalogosAR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiNuevaAR,
            this.cmiAbrirAR});
            this.cmCatalogosAR.Name = "contextMenuStrip1";
            this.cmCatalogosAR.Size = new System.Drawing.Size(119, 48);
            // 
            // cmiNuevaAR
            // 
            this.cmiNuevaAR.Name = "cmiNuevaAR";
            this.cmiNuevaAR.Size = new System.Drawing.Size(118, 22);
            this.cmiNuevaAR.Text = "Nuevo...";
            this.cmiNuevaAR.Click += new System.EventHandler(this.cmiNuevaAR_Click);
            // 
            // cmiAbrirAR
            // 
            this.cmiAbrirAR.Name = "cmiAbrirAR";
            this.cmiAbrirAR.Size = new System.Drawing.Size(118, 22);
            this.cmiAbrirAR.Text = "Abrir...";
            this.cmiAbrirAR.Click += new System.EventHandler(this.cmiAbrirAR_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(616, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(722, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbEjemplares
            // 
            this.txbEjemplares.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbEjemplares.Enabled = false;
            this.txbEjemplares.Location = new System.Drawing.Point(254, 299);
            this.txbEjemplares.Name = "txbEjemplares";
            this.txbEjemplares.Size = new System.Drawing.Size(70, 26);
            this.txbEjemplares.TabIndex = 39;
            this.txbEjemplares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbEjemplares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEjemplares_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarLibro.Location = new System.Drawing.Point(707, 107);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(37, 26);
            this.btnBuscarLibro.TabIndex = 41;
            this.btnBuscarLibro.Text = "...";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Visible = false;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // Frm_Libros
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(834, 384);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txbEjemplares);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.cmbEditorial);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbAnio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbEdicion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(850, 400);
            this.Name = "Frm_Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración - Libros";
            this.Load += new System.EventHandler(this.Frm_Libros_Load);
            this.Shown += new System.EventHandler(this.Frm_Libros_Shown);
            this.cmCatalogosAU.ResumeLayout(false);
            this.cmCatalogosED.ResumeLayout(false);
            this.cmCatalogosAR.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEdicion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbAnio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbEjemplares;
        private System.Windows.Forms.ContextMenuStrip cmCatalogosED;
        private System.Windows.Forms.ToolStripMenuItem cmiNuevoED;
        private System.Windows.Forms.ToolStripMenuItem cmiAbrirED;
        private System.Windows.Forms.ContextMenuStrip cmCatalogosAU;
        private System.Windows.Forms.ToolStripMenuItem cmiNuevoAU;
        private System.Windows.Forms.ToolStripMenuItem cmiAbrirAU;
        private System.Windows.Forms.ContextMenuStrip cmCatalogosAR;
        private System.Windows.Forms.ToolStripMenuItem cmiNuevaAR;
        private System.Windows.Forms.ToolStripMenuItem cmiAbrirAR;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Button btnBuscarLibro;
    }
}