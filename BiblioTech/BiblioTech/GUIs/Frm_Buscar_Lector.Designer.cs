namespace BiblioTech.GUIs
{
    partial class Frm_Buscar_Lector
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gridLectores = new DevExpress.XtraGrid.GridControl();
            this.usuarioBusquedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvLectores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreLector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblPaginacion = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBusquedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLectores)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombre.Location = new System.Drawing.Point(75, 39);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(747, 21);
            this.txbNombre.TabIndex = 33;
            this.txbNombre.TextChanged += new System.EventHandler(this.txbNombre_TextChanged);
            this.txbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMatricula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(834, 40);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Buscar Lector";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridLectores
            // 
            this.gridLectores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLectores.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridLectores.DataSource = this.usuarioBusquedaBindingSource;
            this.gridLectores.Location = new System.Drawing.Point(12, 95);
            this.gridLectores.LookAndFeel.SkinName = "Metropolis";
            this.gridLectores.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridLectores.MainView = this.gvLectores;
            this.gridLectores.Name = "gridLectores";
            this.gridLectores.Size = new System.Drawing.Size(810, 319);
            this.gridLectores.TabIndex = 35;
            this.gridLectores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLectores});
            // 
            // usuarioBusquedaBindingSource
            // 
            this.usuarioBusquedaBindingSource.DataSource = typeof(BiblioTech.Modelos.UsuarioBusqueda);
            // 
            // gvLectores
            // 
            this.gvLectores.Appearance.EvenRow.BackColor = System.Drawing.Color.Gainsboro;
            this.gvLectores.Appearance.EvenRow.BackColor2 = System.Drawing.Color.Gainsboro;
            this.gvLectores.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvLectores.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLectores.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLectores.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLectores.Appearance.Row.Options.UseFont = true;
            this.gvLectores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatricula,
            this.colNombreLector});
            this.gvLectores.GridControl = this.gridLectores;
            this.gvLectores.Name = "gvLectores";
            this.gvLectores.OptionsBehavior.Editable = false;
            this.gvLectores.OptionsView.EnableAppearanceEvenRow = true;
            this.gvLectores.OptionsView.ShowGroupPanel = false;
            // 
            // colMatricula
            // 
            this.colMatricula.FieldName = "Matricula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.Visible = true;
            this.colMatricula.VisibleIndex = 0;
            // 
            // colNombreLector
            // 
            this.colNombreLector.Caption = "Lector";
            this.colNombreLector.FieldName = "NombreLector";
            this.colNombreLector.Name = "colNombreLector";
            this.colNombreLector.OptionsColumn.ReadOnly = true;
            this.colNombreLector.Visible = true;
            this.colNombreLector.VisibleIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(616, 420);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 30);
            this.btnAceptar.TabIndex = 37;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(722, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnAnterior.Location = new System.Drawing.Point(773, 66);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(25, 23);
            this.btnAnterior.TabIndex = 41;
            this.btnAnterior.Text = "t";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSiguiente.Location = new System.Drawing.Point(797, 66);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(25, 23);
            this.btnSiguiente.TabIndex = 40;
            this.btnSiguiente.Text = "u";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblPaginacion
            // 
            this.lblPaginacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaginacion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginacion.Location = new System.Drawing.Point(605, 66);
            this.lblPaginacion.Name = "lblPaginacion";
            this.lblPaginacion.Size = new System.Drawing.Size(166, 23);
            this.lblPaginacion.TabIndex = 39;
            this.lblPaginacion.Text = "Página 0 de 0";
            this.lblPaginacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(12, 66);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(257, 23);
            this.lblCount.TabIndex = 38;
            this.lblCount.Text = "Libros encontrados : 0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_Buscar_Lector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblPaginacion);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gridLectores);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.KeyPreview = true;
            this.Name = "Frm_Buscar_Lector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administración - Buscar_Lector";
            this.Shown += new System.EventHandler(this.Frm_Buscar_Lector_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridLectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBusquedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraGrid.GridControl gridLectores;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLectores;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource usuarioBusquedaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreLector;
        private DevExpress.XtraGrid.Columns.GridColumn colMatricula;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblPaginacion;
        private System.Windows.Forms.Label lblCount;
    }
}