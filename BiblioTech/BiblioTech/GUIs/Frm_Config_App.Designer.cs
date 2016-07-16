namespace BiblioTech.GUIs
{
    partial class Frm_Config_App
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
            this.GrpBaseDeDatos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbBasesDeDatos = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPuerto = new System.Windows.Forms.TextBox();
            this.GrpBaseDeDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(834, 40);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Configuración";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrpBaseDeDatos
            // 
            this.GrpBaseDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBaseDeDatos.Controls.Add(this.txbPuerto);
            this.GrpBaseDeDatos.Controls.Add(this.btnCancelar);
            this.GrpBaseDeDatos.Controls.Add(this.cmbBasesDeDatos);
            this.GrpBaseDeDatos.Controls.Add(this.btnGuardar);
            this.GrpBaseDeDatos.Controls.Add(this.label5);
            this.GrpBaseDeDatos.Controls.Add(this.label4);
            this.GrpBaseDeDatos.Controls.Add(this.txbContraseña);
            this.GrpBaseDeDatos.Controls.Add(this.label3);
            this.GrpBaseDeDatos.Controls.Add(this.txbUsuario);
            this.GrpBaseDeDatos.Controls.Add(this.label2);
            this.GrpBaseDeDatos.Controls.Add(this.txbServidor);
            this.GrpBaseDeDatos.Controls.Add(this.label1);
            this.GrpBaseDeDatos.Location = new System.Drawing.Point(12, 43);
            this.GrpBaseDeDatos.Name = "GrpBaseDeDatos";
            this.GrpBaseDeDatos.Size = new System.Drawing.Size(810, 307);
            this.GrpBaseDeDatos.TabIndex = 17;
            this.GrpBaseDeDatos.TabStop = false;
            this.GrpBaseDeDatos.Text = "Configurar conexión a la base de datos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(409, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbBasesDeDatos
            // 
            this.cmbBasesDeDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBasesDeDatos.FormattingEnabled = true;
            this.cmbBasesDeDatos.Location = new System.Drawing.Point(201, 174);
            this.cmbBasesDeDatos.Name = "cmbBasesDeDatos";
            this.cmbBasesDeDatos.Size = new System.Drawing.Size(520, 26);
            this.cmbBasesDeDatos.TabIndex = 12;
            this.cmbBasesDeDatos.Click += new System.EventHandler(this.cmbBasesDeDatos_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(303, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Base de datos:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puerto:";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbContraseña.Location = new System.Drawing.Point(201, 110);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(401, 26);
            this.txbContraseña.TabIndex = 5;
            this.txbContraseña.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbUsuario.Location = new System.Drawing.Point(201, 78);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(520, 26);
            this.txbUsuario.TabIndex = 3;
            this.txbUsuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // txbServidor
            // 
            this.txbServidor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbServidor.Location = new System.Drawing.Point(201, 46);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(520, 26);
            this.txbServidor.TabIndex = 1;
            this.txbServidor.Text = "Servidor";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor:";
            // 
            // txbPuerto
            // 
            this.txbPuerto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPuerto.Location = new System.Drawing.Point(201, 142);
            this.txbPuerto.Name = "txbPuerto";
            this.txbPuerto.Size = new System.Drawing.Size(97, 26);
            this.txbPuerto.TabIndex = 14;
            this.txbPuerto.Text = "Contraseña";
            // 
            // Frm_Config_App
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(834, 362);
            this.Controls.Add(this.GrpBaseDeDatos);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(850, 400);
            this.Name = "Frm_Config_App";
            this.Text = "Administración - Configuracón";
            this.Shown += new System.EventHandler(this.Frm_Config_App_Shown);
            this.GrpBaseDeDatos.ResumeLayout(false);
            this.GrpBaseDeDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox GrpBaseDeDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbBasesDeDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPuerto;
    }
}