namespace BiblioTech.GUIs
{
    partial class Frm_Consultas
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
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_autor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_editorial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_ejemplares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txbArea = new System.Windows.Forms.TextBox();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblPaginacion = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.pbCargando = new System.Windows.Forms.PictureBox();
            this.bgwBuscar = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(784, 30);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Consultar Libros";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridConsulta
            // 
            this.gridConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridConsulta.DataSource = this.librosBindingSource;
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gridConsulta.Location = new System.Drawing.Point(0, 116);
            this.gridConsulta.LookAndFeel.SkinName = "Metropolis";
            this.gridConsulta.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridConsulta.MainView = this.gvConsulta;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.Size = new System.Drawing.Size(784, 255);
            this.gridConsulta.TabIndex = 16;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConsulta});
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataSource = typeof(BiblioTech.Entity.libros);
            // 
            // gvConsulta
            // 
            this.gvConsulta.Appearance.EvenRow.BackColor = System.Drawing.Color.Gainsboro;
            this.gvConsulta.Appearance.EvenRow.BackColor2 = System.Drawing.Color.Gainsboro;
            this.gvConsulta.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvConsulta.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvConsulta.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvConsulta.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvConsulta.Appearance.Row.Options.UseFont = true;
            this.gvConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colclave,
            this.coltitulo,
            this.colf_autor,
            this.colf_editorial,
            this.colf_area,
            this.coledicion,
            this.colanio,
            this.colno_ejemplares});
            this.gvConsulta.GridControl = this.gridConsulta;
            this.gvConsulta.Name = "gvConsulta";
            this.gvConsulta.OptionsBehavior.Editable = false;
            this.gvConsulta.OptionsView.EnableAppearanceEvenRow = true;
            this.gvConsulta.OptionsView.ShowGroupPanel = false;
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
            // colno_ejemplares
            // 
            this.colno_ejemplares.Caption = "Ejemplares";
            this.colno_ejemplares.FieldName = "no_ejemplares";
            this.colno_ejemplares.Name = "colno_ejemplares";
            this.colno_ejemplares.Visible = true;
            this.colno_ejemplares.VisibleIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Area:";
            // 
            // txbArea
            // 
            this.txbArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbArea.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbArea.Location = new System.Drawing.Point(544, 31);
            this.txbArea.Name = "txbArea";
            this.txbArea.Size = new System.Drawing.Size(150, 23);
            this.txbArea.TabIndex = 18;
            // 
            // txbAutor
            // 
            this.txbAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbAutor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutor.Location = new System.Drawing.Point(278, 31);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(260, 23);
            this.txbAutor.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Autor:";
            // 
            // txbTitulo
            // 
            this.txbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitulo.Location = new System.Drawing.Point(12, 31);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(260, 23);
            this.txbTitulo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(703, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 28);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 371);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(784, 40);
            this.pnlBotones.TabIndex = 24;
            this.pnlBotones.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(567, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 30);
            this.btnAceptar.TabIndex = 39;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(673, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.btnAnterior);
            this.pnlFiltros.Controls.Add(this.btnSiguiente);
            this.pnlFiltros.Controls.Add(this.lblPaginacion);
            this.pnlFiltros.Controls.Add(this.lblCount);
            this.pnlFiltros.Controls.Add(this.txbAutor);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Controls.Add(this.label1);
            this.pnlFiltros.Controls.Add(this.txbTitulo);
            this.pnlFiltros.Controls.Add(this.txbArea);
            this.pnlFiltros.Controls.Add(this.label3);
            this.pnlFiltros.Controls.Add(this.label2);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 30);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(784, 86);
            this.pnlFiltros.TabIndex = 25;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnAnterior.Location = new System.Drawing.Point(732, 60);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(25, 23);
            this.btnAnterior.TabIndex = 27;
            this.btnAnterior.Text = "t";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSiguiente.Location = new System.Drawing.Point(756, 60);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(25, 23);
            this.btnSiguiente.TabIndex = 26;
            this.btnSiguiente.Text = "u";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblPaginacion
            // 
            this.lblPaginacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaginacion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginacion.Location = new System.Drawing.Point(566, 60);
            this.lblPaginacion.Name = "lblPaginacion";
            this.lblPaginacion.Size = new System.Drawing.Size(166, 23);
            this.lblPaginacion.TabIndex = 25;
            this.lblPaginacion.Text = "Página 0 de 0";
            this.lblPaginacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(12, 57);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(260, 23);
            this.lblCount.TabIndex = 24;
            this.lblCount.Text = "Libros encontrados : 0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbCargando
            // 
            this.pbCargando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCargando.Image = global::BiblioTech.Properties.Resources.preloader;
            this.pbCargando.Location = new System.Drawing.Point(267, 91);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(250, 229);
            this.pbCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCargando.TabIndex = 26;
            this.pbCargando.TabStop = false;
            this.pbCargando.Visible = false;
            // 
            // bgwBuscar
            // 
            this.bgwBuscar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBuscar_DoWork);
            this.bgwBuscar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBuscar_RunWorkerCompleted);
            // 
            // Frm_Consultas
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.pbCargando);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "Frm_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultas de libros";
            this.Shown += new System.EventHandler(this.Frm_Consultas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbArea;
        private System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colclave;
        private DevExpress.XtraGrid.Columns.GridColumn coltitulo;
        private DevExpress.XtraGrid.Columns.GridColumn coledicion;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
        private DevExpress.XtraGrid.Columns.GridColumn colno_ejemplares;
        private DevExpress.XtraGrid.Columns.GridColumn colf_autor;
        private DevExpress.XtraGrid.Columns.GridColumn colf_editorial;
        private DevExpress.XtraGrid.Columns.GridColumn colf_area;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbCargando;
        private System.ComponentModel.BackgroundWorker bgwBuscar;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblPaginacion;
    }
}