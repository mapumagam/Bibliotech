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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.gvConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_autor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_editorial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colf_area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colanio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_ejemplares = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(212, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 58);
            this.textBox1.TabIndex = 23;
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
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(632, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Buscar Libro";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(632, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 27);
            this.button2.TabIndex = 27;
            this.button2.Text = "Buscar Lector";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(342, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 27);
            this.button3.TabIndex = 28;
            this.button3.Text = "Agregar a la lista";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(616, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 30;
            this.button4.Text = "Aceptar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(722, 420);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 31;
            this.button5.Text = "Cancelar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataSource = typeof(BiblioTech.Entity.libros);
            // 
            // gridConsulta
            // 
            this.gridConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridConsulta.DataSource = this.librosBindingSource;
            this.gridConsulta.Location = new System.Drawing.Point(12, 172);
            this.gridConsulta.LookAndFeel.SkinName = "Metropolis";
            this.gridConsulta.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridConsulta.MainView = this.gvConsulta;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.Size = new System.Drawing.Size(810, 242);
            this.gridConsulta.TabIndex = 32;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConsulta});
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
            this.colf_autor.FieldName = "f_autor.descripcion";
            this.colf_autor.Name = "colf_autor";
            this.colf_autor.Visible = true;
            this.colf_autor.VisibleIndex = 2;
            // 
            // colf_editorial
            // 
            this.colf_editorial.Caption = "Editorial";
            this.colf_editorial.FieldName = "f_editorial.descripcion";
            this.colf_editorial.Name = "colf_editorial";
            this.colf_editorial.Visible = true;
            this.colf_editorial.VisibleIndex = 3;
            // 
            // colf_area
            // 
            this.colf_area.Caption = "Área";
            this.colf_area.FieldName = "f_area.descripcion";
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
            // Frm_Prestamos
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(850, 400);
            this.Name = "Frm_Prestamos";
            this.Text = "Administración - Prestamos de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colclave;
        private DevExpress.XtraGrid.Columns.GridColumn coltitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colf_autor;
        private DevExpress.XtraGrid.Columns.GridColumn colf_editorial;
        private DevExpress.XtraGrid.Columns.GridColumn colf_area;
        private DevExpress.XtraGrid.Columns.GridColumn coledicion;
        private DevExpress.XtraGrid.Columns.GridColumn colanio;
        private DevExpress.XtraGrid.Columns.GridColumn colno_ejemplares;
    }
}