namespace BiblioTech.GUIs
{
    partial class Frm_Devoluciones
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
            this.btnBuscarLector = new System.Windows.Forms.Button();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.libroDevolucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLibro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroDevolucionBindingSource)).BeginInit();
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
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Devoluciones de Libros";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarLector
            // 
            this.btnBuscarLector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarLector.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLector.Location = new System.Drawing.Point(602, 43);
            this.btnBuscarLector.Name = "btnBuscarLector";
            this.btnBuscarLector.Size = new System.Drawing.Size(150, 27);
            this.btnBuscarLector.TabIndex = 30;
            this.btnBuscarLector.Text = "Buscar Lector";
            this.btnBuscarLector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLector.UseVisualStyleBackColor = true;
            this.btnBuscarLector.Click += new System.EventHandler(this.btnBuscarLector_Click);
            // 
            // txbMatricula
            // 
            this.txbMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMatricula.Enabled = false;
            this.txbMatricula.ForeColor = System.Drawing.Color.Black;
            this.txbMatricula.Location = new System.Drawing.Point(182, 43);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(414, 26);
            this.txbMatricula.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID / Matricula:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(722, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolver.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(616, 320);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(100, 30);
            this.btnDevolver.TabIndex = 33;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // gridConsulta
            // 
            this.gridConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridConsulta.DataSource = this.libroDevolucionBindingSource;
            this.gridConsulta.Location = new System.Drawing.Point(12, 76);
            this.gridConsulta.LookAndFeel.SkinName = "Metropolis";
            this.gridConsulta.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridConsulta.MainView = this.gvConsulta;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.Size = new System.Drawing.Size(810, 238);
            this.gridConsulta.TabIndex = 34;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConsulta});
            // 
            // libroDevolucionBindingSource
            // 
            this.libroDevolucionBindingSource.DataSource = typeof(BiblioTech.Modelos.LibroDevolucion);
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
            this.colSeleccionado,
            this.colLibro,
            this.gridColumn1});
            this.gvConsulta.GridControl = this.gridConsulta;
            this.gvConsulta.Name = "gvConsulta";
            this.gvConsulta.OptionsView.EnableAppearanceEvenRow = true;
            this.gvConsulta.OptionsView.ShowGroupPanel = false;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.Caption = " ";
            this.colSeleccionado.FieldName = "Seleccionado";
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 0;
            // 
            // colLibro
            // 
            this.colLibro.Caption = "Titulo";
            this.colLibro.FieldName = "Libro.titulo";
            this.colLibro.Name = "colLibro";
            this.colLibro.OptionsColumn.AllowEdit = false;
            this.colLibro.Visible = true;
            this.colLibro.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Autor";
            this.gridColumn1.FieldName = "Libro.f_autor.descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // Frm_Devoluciones
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(834, 362);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscarLector);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Devoluciones";
            this.Text = "Administración - Devoluciones";
            this.Load += new System.EventHandler(this.Frm_Devoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroDevolucionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscarLector;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDevolver;
        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConsulta;
        private System.Windows.Forms.BindingSource libroDevolucionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colLibro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}