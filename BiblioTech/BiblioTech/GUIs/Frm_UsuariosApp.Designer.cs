namespace BiblioTech.GUIs
{
    partial class Frm_UsuariosApp
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkConsulta = new System.Windows.Forms.CheckBox();
            this.chkReportes = new System.Windows.Forms.CheckBox();
            this.btnAccion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbNombreCompleto = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(684, 40);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Usuarios Aplicación";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre completo:";
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbUsername.Enabled = false;
            this.txbUsername.Location = new System.Drawing.Point(197, 116);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(270, 26);
            this.txbUsername.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de usuario:";
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPassword.Enabled = false;
            this.txbPassword.Location = new System.Drawing.Point(197, 148);
            this.txbPassword.MaxLength = 15;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(270, 26);
            this.txbPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Permisos:";
            // 
            // chkAdmin
            // 
            this.chkAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Enabled = false;
            this.chkAdmin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmin.Location = new System.Drawing.Point(197, 213);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(123, 20);
            this.chkAdmin.TabIndex = 9;
            this.chkAdmin.Text = "Administración";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chkConsulta
            // 
            this.chkConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkConsulta.AutoSize = true;
            this.chkConsulta.Enabled = false;
            this.chkConsulta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConsulta.Location = new System.Drawing.Point(197, 239);
            this.chkConsulta.Name = "chkConsulta";
            this.chkConsulta.Size = new System.Drawing.Size(90, 20);
            this.chkConsulta.TabIndex = 10;
            this.chkConsulta.Text = "Consultas";
            this.chkConsulta.UseVisualStyleBackColor = true;
            // 
            // chkReportes
            // 
            this.chkReportes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkReportes.AutoSize = true;
            this.chkReportes.Enabled = false;
            this.chkReportes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReportes.Location = new System.Drawing.Point(197, 265);
            this.chkReportes.Name = "chkReportes";
            this.chkReportes.Size = new System.Drawing.Size(87, 20);
            this.chkReportes.TabIndex = 11;
            this.chkReportes.Text = "Reportes";
            this.chkReportes.UseVisualStyleBackColor = true;
            // 
            // btnAccion
            // 
            this.btnAccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccion.Location = new System.Drawing.Point(466, 298);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(100, 30);
            this.btnAccion.TabIndex = 13;
            this.btnAccion.Text = "Aceptar";
            this.btnAccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Visible = false;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(572, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // cmbNombreCompleto
            // 
            this.cmbNombreCompleto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbNombreCompleto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbNombreCompleto.Enabled = false;
            this.cmbNombreCompleto.FormattingEnabled = true;
            this.cmbNombreCompleto.Location = new System.Drawing.Point(197, 84);
            this.cmbNombreCompleto.Name = "cmbNombreCompleto";
            this.cmbNombreCompleto.Size = new System.Drawing.Size(420, 26);
            this.cmbNombreCompleto.TabIndex = 3;
            this.cmbNombreCompleto.SelectedIndexChanged += new System.EventHandler(this.cmbNombreCompleto_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(360, 298);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 30);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Frm_UsuariosApp
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.cmbNombreCompleto);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.chkReportes);
            this.Controls.Add(this.chkConsulta);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "Frm_UsuariosApp";
            this.Text = "Administración - Usuarios Aplicación";
            this.Shown += new System.EventHandler(this.Frm_UsuariosApp_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkConsulta;
        private System.Windows.Forms.CheckBox chkReportes;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbNombreCompleto;
        private System.Windows.Forms.Button btnBorrar;
    }
}