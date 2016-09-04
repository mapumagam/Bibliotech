namespace BiblioTech.GUIs
{
    partial class Frm_Prestamos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnBuscarLector = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridPrestamos = new DevExpress.XtraGrid.GridControl();
            this.gvPrestamos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_autor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_editorial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(834, 40);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Prestamo de Libros";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbMatricula
            // 
            this.txbMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMatricula.Enabled = false;
            this.txbMatricula.Location = new System.Drawing.Point(212, 43);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(414, 26);
            this.txbMatricula.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID / Matricula:";
            // 
            // txbTitulo
            // 
            this.txbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTitulo.Enabled = false;
            this.txbTitulo.Location = new System.Drawing.Point(212, 75);
            this.txbTitulo.Multiline = true;
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(414, 58);
            this.txbTitulo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Titulo:";
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarLibro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLibro.Location = new System.Drawing.Point(632, 74);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(150, 30);
            this.btnBuscarLibro.TabIndex = 26;
            this.btnBuscarLibro.Text = "Buscar Libro";
            this.btnBuscarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnBuscarLector
            // 
            this.btnBuscarLector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarLector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLector.Location = new System.Drawing.Point(632, 41);
            this.btnBuscarLector.Name = "btnBuscarLector";
            this.btnBuscarLector.Size = new System.Drawing.Size(150, 30);
            this.btnBuscarLector.TabIndex = 27;
            this.btnBuscarLector.Text = "Buscar Lector";
            this.btnBuscarLector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLector.UseVisualStyleBackColor = true;
            this.btnBuscarLector.Click += new System.EventHandler(this.btnBuscarLector_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(342, 139);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 30);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar a la lista";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(616, 420);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 30);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(722, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataSource = typeof(BiblioTech.Entity.libros);
            // 
            // gridPrestamos
            // 
            this.gridPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPrestamos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPrestamos.DataSource = this.librosBindingSource;
            this.gridPrestamos.Location = new System.Drawing.Point(12, 175);
            this.gridPrestamos.LookAndFeel.SkinName = "Metropolis";
            this.gridPrestamos.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridPrestamos.MainView = this.gvPrestamos;
            this.gridPrestamos.Name = "gridPrestamos";
            this.gridPrestamos.Size = new System.Drawing.Size(810, 239);
            this.gridPrestamos.TabIndex = 32;
            this.gridPrestamos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrestamos});
            // 
            // gvPrestamos
            // 
            this.gvPrestamos.Appearance.EvenRow.BackColor = System.Drawing.Color.Gainsboro;
            this.gvPrestamos.Appearance.EvenRow.BackColor2 = System.Drawing.Color.Gainsboro;
            this.gvPrestamos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPrestamos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPrestamos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPrestamos.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPrestamos.Appearance.Row.Options.UseFont = true;
            this.gvPrestamos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colclave,
            this.coltitulo,
            this.colf_autor,
            this.colf_editorial,
            this.colf_area,
            this.coledicion,
            this.colanio});
            this.gvPrestamos.GridControl = this.gridPrestamos;
            this.gvPrestamos.Name = "gvPrestamos";
            this.gvPrestamos.OptionsBehavior.Editable = false;
            this.gvPrestamos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPrestamos.OptionsView.ShowGroupPanel = false;
            // 
            // colclave
            // 
            this.colclave.Caption = "Clave";
            this.colclave.FieldName = "clave";
            this.colclave.Name = "colclave";
            this.colclave.Visible = true;
            this.colclave.VisibleIndex = 0;
            // 
            // coltitulo
            // 
            this.coltitulo.Caption = "Titulo";
            this.coltitulo.FieldName = "titulo";
            this.coltitulo.Name = "coltitulo";
            this.coltitulo.Visible = true;
            this.coltitulo.VisibleIndex = 1;
            // 
            // colf_autor
            // 
            this.colf_autor.Caption = "Autor";
            this.colf_autor.FieldName = "autor.descripcion";
            this.colf_autor.Name = "colf_autor";
            this.colf_autor.Visible = true;
            this.colf_autor.VisibleIndex = 2;
            // 
            // colf_editorial
            // 
            this.colf_editorial.Caption = "Editorial";
            this.colf_editorial.FieldName = "editorial.descripcion";
            this.colf_editorial.Name = "colf_editorial";
            this.colf_editorial.Visible = true;
            this.colf_editorial.VisibleIndex = 3;
            // 
            // colf_area
            // 
            this.colf_area.Caption = "Área";
            this.colf_area.FieldName = "area.descripcion";
            this.colf_area.Name = "colf_area";
            this.colf_area.Visible = true;
            this.colf_area.VisibleIndex = 4;
            // 
            // coledicion
            // 
            this.coledicion.Caption = "Edición";
            this.coledicion.FieldName = "edicion";
            this.coledicion.Name = "coledicion";
            this.coledicion.Visible = true;
            this.coledicion.VisibleIndex = 5;
            // 
            // colanio
            // 
            this.colanio.Caption = "Año";
            this.colanio.FieldName = "anio";
            this.colanio.Name = "colanio";
            this.colanio.Visible = true;
            this.colanio.VisibleIndex = 6;
            // 
            // Frm_Prestamos
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.gridPrestamos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscarLector);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(850, 400);
            this.Name = "Frm_Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administración - Prestamos de Libros";
            this.Shown += new System.EventHandler(this.Frm_Prestamos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.Button btnBuscarLector;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DevExpress.XtraGrid.GridControl gridPrestamos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrestamos;
        private DevExpress.XtraGrid.Columns.GridColumn colclave;
        private DevExpress.XtraGrid.Columns.GridColumn coltitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colf_autor;
        private DevExpress.XtraGrid.Columns.GridColumn colf_editorial;
        private DevExpress.XtraGrid.Columns.GridColumn colf_area;
        private DevExpress.XtraGrid.Columns.GridColumn coledicion;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
    }
}