namespace BiblioTech.GUIs
{
    partial class Frm_Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbPrimerNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSegundoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoLector = new System.Windows.Forms.ComboBox();
            this.btnAccion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbMatricula = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID / Matricula:";
            // 
            // txbPrimerNombre
            // 
            this.txbPrimerNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPrimerNombre.Enabled = false;
            this.txbPrimerNombre.Location = new System.Drawing.Point(221, 109);
            this.txbPrimerNombre.Name = "txbPrimerNombre";
            this.txbPrimerNombre.Size = new System.Drawing.Size(522, 26);
            this.txbPrimerNombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Primer Nombre:";
            // 
            // txbSegundoNombre
            // 
            this.txbSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbSegundoNombre.Enabled = false;
            this.txbSegundoNombre.Location = new System.Drawing.Point(221, 141);
            this.txbSegundoNombre.Name = "txbSegundoNombre";
            this.txbSegundoNombre.Size = new System.Drawing.Size(522, 26);
            this.txbSegundoNombre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Segundo Nombre:";
            // 
            // txbApellidoPaterno
            // 
            this.txbApellidoPaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbApellidoPaterno.Enabled = false;
            this.txbApellidoPaterno.Location = new System.Drawing.Point(221, 173);
            this.txbApellidoPaterno.Name = "txbApellidoPaterno";
            this.txbApellidoPaterno.Size = new System.Drawing.Size(522, 26);
            this.txbApellidoPaterno.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido Paterno:";
            // 
            // txbApellidoMaterno
            // 
            this.txbApellidoMaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbApellidoMaterno.Enabled = false;
            this.txbApellidoMaterno.Location = new System.Drawing.Point(221, 205);
            this.txbApellidoMaterno.Name = "txbApellidoMaterno";
            this.txbApellidoMaterno.Size = new System.Drawing.Size(522, 26);
            this.txbApellidoMaterno.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido Materno:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Lector:";
            // 
            // cmbTipoLector
            // 
            this.cmbTipoLector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoLector.Enabled = false;
            this.cmbTipoLector.FormattingEnabled = true;
            this.cmbTipoLector.Location = new System.Drawing.Point(221, 237);
            this.cmbTipoLector.Name = "cmbTipoLector";
            this.cmbTipoLector.Size = new System.Drawing.Size(269, 26);
            this.cmbTipoLector.TabIndex = 13;
            // 
            // btnAccion
            // 
            this.btnAccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccion.Location = new System.Drawing.Point(596, 300);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(110, 30);
            this.btnAccion.TabIndex = 14;
            this.btnAccion.Text = "Guardar";
            this.btnAccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(712, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 30);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(834, 40);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lectores";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 15;
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
            // cmbMatricula
            // 
            this.cmbMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbMatricula.FormattingEnabled = true;
            this.cmbMatricula.Location = new System.Drawing.Point(221, 77);
            this.cmbMatricula.Name = "cmbMatricula";
            this.cmbMatricula.Size = new System.Drawing.Size(269, 26);
            this.cmbMatricula.TabIndex = 16;
            this.cmbMatricula.SelectedIndexChanged += new System.EventHandler(this.cmbMatricula_SelectedIndexChanged);
            // 
            // Frm_Usuarios
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(834, 342);
            this.Controls.Add(this.cmbMatricula);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.cmbTipoLector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbApellidoMaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbApellidoPaterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSegundoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPrimerNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Usuarios";
            this.Text = "Administración - Lectores";
            this.Shown += new System.EventHandler(this.Frm_Usuarios_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPrimerNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSegundoNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbApellidoPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbApellidoMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoLector;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbMatricula;

    }
}