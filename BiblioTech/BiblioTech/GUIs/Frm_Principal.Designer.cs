namespace BiblioTech.GUIs
{
    partial class Frm_Principal
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
            this.pnlTitulo = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.navItemUsuarios = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemLibros = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemConsultar = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemPrestamo = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemPerdidos = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemReporLibros = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemDevolucion = new DevExpress.XtraNavBar.NavBarItem();
            this.navGroupAdministracion = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemUsuariosApp = new DevExpress.XtraNavBar.NavBarItem();
            this.navGroupConsulta = new DevExpress.XtraNavBar.NavBarGroup();
            this.navGroupReportes = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBar = new DevExpress.XtraNavBar.NavBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Appearance.BackColor = System.Drawing.Color.Black;
            this.pnlTitulo.Appearance.BackColor2 = System.Drawing.Color.Silver;
            this.pnlTitulo.Appearance.ForeColor = System.Drawing.Color.White;
            this.pnlTitulo.Appearance.Options.UseBackColor = true;
            this.pnlTitulo.Appearance.Options.UseForeColor = true;
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(934, 40);
            this.pnlTitulo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(930, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca Francisco Zarco";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navItemUsuarios
            // 
            this.navItemUsuarios.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemUsuarios.Appearance.Options.UseFont = true;
            this.navItemUsuarios.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemUsuarios.AppearanceHotTracked.Options.UseFont = true;
            this.navItemUsuarios.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemUsuarios.AppearancePressed.Options.UseFont = true;
            this.navItemUsuarios.Caption = "Lectores";
            this.navItemUsuarios.Name = "navItemUsuarios";
            this.navItemUsuarios.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemUsuarios_LinkClicked);
            // 
            // navItemLibros
            // 
            this.navItemLibros.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemLibros.Appearance.Options.UseFont = true;
            this.navItemLibros.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemLibros.AppearanceHotTracked.Options.UseFont = true;
            this.navItemLibros.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemLibros.AppearancePressed.Options.UseFont = true;
            this.navItemLibros.Caption = "Libros";
            this.navItemLibros.Name = "navItemLibros";
            this.navItemLibros.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemLibros_LinkClicked);
            // 
            // navItemConsultar
            // 
            this.navItemConsultar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemConsultar.Appearance.Options.UseFont = true;
            this.navItemConsultar.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemConsultar.AppearanceHotTracked.Options.UseFont = true;
            this.navItemConsultar.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemConsultar.AppearancePressed.Options.UseFont = true;
            this.navItemConsultar.Caption = "Buscar Libros";
            this.navItemConsultar.Name = "navItemConsultar";
            this.navItemConsultar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemConsultar_LinkClicked);
            // 
            // navItemPrestamo
            // 
            this.navItemPrestamo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemPrestamo.Appearance.Options.UseFont = true;
            this.navItemPrestamo.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemPrestamo.AppearanceHotTracked.Options.UseFont = true;
            this.navItemPrestamo.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemPrestamo.AppearancePressed.Options.UseFont = true;
            this.navItemPrestamo.Caption = "Prestamo de libros";
            this.navItemPrestamo.Name = "navItemPrestamo";
            this.navItemPrestamo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemPrestamo_LinkClicked);
            // 
            // navItemPerdidos
            // 
            this.navItemPerdidos.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemPerdidos.Appearance.Options.UseFont = true;
            this.navItemPerdidos.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemPerdidos.AppearanceHotTracked.Options.UseFont = true;
            this.navItemPerdidos.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemPerdidos.AppearancePressed.Options.UseFont = true;
            this.navItemPerdidos.Caption = "Libros Perdidos";
            this.navItemPerdidos.Name = "navItemPerdidos";
            this.navItemPerdidos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemPerdidos_LinkClicked);
            // 
            // navItemReporLibros
            // 
            this.navItemReporLibros.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemReporLibros.Appearance.Options.UseFont = true;
            this.navItemReporLibros.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemReporLibros.AppearanceHotTracked.Options.UseFont = true;
            this.navItemReporLibros.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemReporLibros.AppearancePressed.Options.UseFont = true;
            this.navItemReporLibros.Caption = "Reporte de Libros";
            this.navItemReporLibros.Name = "navItemReporLibros";
            // 
            // navItemDevolucion
            // 
            this.navItemDevolucion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemDevolucion.Appearance.Options.UseFont = true;
            this.navItemDevolucion.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemDevolucion.AppearanceHotTracked.Options.UseFont = true;
            this.navItemDevolucion.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemDevolucion.AppearancePressed.Options.UseFont = true;
            this.navItemDevolucion.Caption = "Devoluciones de libros";
            this.navItemDevolucion.Name = "navItemDevolucion";
            this.navItemDevolucion.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemDevolucion_LinkClicked);
            // 
            // navGroupAdministracion
            // 
            this.navGroupAdministracion.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navGroupAdministracion.Appearance.Options.UseFont = true;
            this.navGroupAdministracion.Caption = "Administración";
            this.navGroupAdministracion.Expanded = true;
            this.navGroupAdministracion.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemLibros),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemUsuarios),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemPrestamo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemDevolucion),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemPerdidos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemUsuariosApp)});
            this.navGroupAdministracion.Name = "navGroupAdministracion";
            this.navGroupAdministracion.Tag = "grpAdmin";
            // 
            // navItemUsuariosApp
            // 
            this.navItemUsuariosApp.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemUsuariosApp.Appearance.Options.UseFont = true;
            this.navItemUsuariosApp.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemUsuariosApp.AppearanceHotTracked.Options.UseFont = true;
            this.navItemUsuariosApp.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navItemUsuariosApp.AppearancePressed.Options.UseFont = true;
            this.navItemUsuariosApp.Caption = "Usuarios Aplicación";
            this.navItemUsuariosApp.Name = "navItemUsuariosApp";
            this.navItemUsuariosApp.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemUsuariosApp_LinkClicked);
            // 
            // navGroupConsulta
            // 
            this.navGroupConsulta.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navGroupConsulta.Appearance.Options.UseFont = true;
            this.navGroupConsulta.Caption = "Consultas";
            this.navGroupConsulta.Expanded = true;
            this.navGroupConsulta.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemConsultar)});
            this.navGroupConsulta.Name = "navGroupConsulta";
            this.navGroupConsulta.Tag = "grpConsultas";
            // 
            // navGroupReportes
            // 
            this.navGroupReportes.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navGroupReportes.Appearance.Options.UseFont = true;
            this.navGroupReportes.Caption = "Reportes";
            this.navGroupReportes.Expanded = true;
            this.navGroupReportes.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemReporLibros)});
            this.navGroupReportes.Name = "navGroupReportes";
            this.navGroupReportes.Tag = "grpReportes";
            // 
            // navBar
            // 
            this.navBar.ActiveGroup = this.navGroupAdministracion;
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navGroupAdministracion,
            this.navGroupConsulta,
            this.navGroupReportes});
            this.navBar.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navItemUsuarios,
            this.navItemLibros,
            this.navItemConsultar,
            this.navItemPrestamo,
            this.navItemPerdidos,
            this.navItemReporLibros,
            this.navItemDevolucion,
            this.navItemUsuariosApp});
            this.navBar.Location = new System.Drawing.Point(0, 40);
            this.navBar.LookAndFeel.SkinName = "Metropolis";
            this.navBar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navBar.Name = "navBar";
            this.navBar.OptionsNavPane.ExpandedWidth = 200;
            this.navBar.Size = new System.Drawing.Size(200, 401);
            this.navBar.TabIndex = 1;
            this.navBar.Text = "navBarControl1";
            // 
            // Frm_Principal
            // 
            this.AllowMdiBar = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(934, 441);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escuela Normal Rural J. Guadalupe Rodriguez - Biblioteca Francisco Zarco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Frm_Principal_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTitulo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraNavBar.NavBarItem navItemUsuarios;
        private DevExpress.XtraNavBar.NavBarItem navItemLibros;
        private DevExpress.XtraNavBar.NavBarItem navItemConsultar;
        private DevExpress.XtraNavBar.NavBarItem navItemPrestamo;
        private DevExpress.XtraNavBar.NavBarItem navItemPerdidos;
        private DevExpress.XtraNavBar.NavBarItem navItemReporLibros;
        private DevExpress.XtraNavBar.NavBarItem navItemDevolucion;
        private DevExpress.XtraNavBar.NavBarGroup navGroupAdministracion;
        private DevExpress.XtraNavBar.NavBarGroup navGroupConsulta;
        private DevExpress.XtraNavBar.NavBarGroup navGroupReportes;
        private DevExpress.XtraNavBar.NavBarControl navBar;
        private DevExpress.XtraNavBar.NavBarItem navItemUsuariosApp;
    }
}