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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).BeginInit();
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
            this.gridConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridConsulta.DataSource = this.librosBindingSource;
            this.gridConsulta.Location = new System.Drawing.Point(0, 82);
            this.gridConsulta.LookAndFeel.SkinName = "Metropolis";
            this.gridConsulta.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridConsulta.MainView = this.gvConsulta;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.Size = new System.Drawing.Size(784, 328);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Area:";
            // 
            // txbArea
            // 
            this.txbArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbArea.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbArea.Location = new System.Drawing.Point(544, 51);
            this.txbArea.Name = "txbArea";
            this.txbArea.Size = new System.Drawing.Size(150, 23);
            this.txbArea.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(278, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 23);
            this.textBox2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Autor:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 23);
            this.textBox3.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(703, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 28);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Frm_Consultas
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Consultas";
            this.Text = "Consultas de libros";
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbArea;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
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
    }
}