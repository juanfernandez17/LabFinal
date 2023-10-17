namespace WinForms
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chbMostrarContraseña = new CheckBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            grbInicio = new GroupBox();
            lblMsgError = new Label();
            lblRespuestaDB = new Label();
            btnRegistro = new Button();
            btnAcceder = new Button();
            lblLogin = new Label();
            btnProbarConexion = new Button();
            lblProbarConexionDB = new Label();
            panel3 = new Panel();
            lblError = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            lblUsuario = new Label();
            lblContraseña = new Label();
            grbInicio.SuspendLayout();
            SuspendLayout();
            // 
            // chbMostrarContraseña
            // 
            chbMostrarContraseña.AutoSize = true;
            chbMostrarContraseña.ForeColor = Color.FromArgb(46, 75, 148);
            chbMostrarContraseña.Location = new Point(129, 303);
            chbMostrarContraseña.Name = "chbMostrarContraseña";
            chbMostrarContraseña.Size = new Size(128, 19);
            chbMostrarContraseña.TabIndex = 11;
            chbMostrarContraseña.Text = "Mostrar contraseña";
            chbMostrarContraseña.UseVisualStyleBackColor = false;
            chbMostrarContraseña.CheckedChanged += chbMostrarContraseña_CheckedChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(129, 221);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(229, 16);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Location = new Point(129, 259);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(229, 16);
            txtContraseña.TabIndex = 1;
            // 
            // grbInicio
            // 
            grbInicio.Anchor = AnchorStyles.None;
            grbInicio.BackColor = Color.White;
            grbInicio.Controls.Add(lblMsgError);
            grbInicio.Controls.Add(lblRespuestaDB);
            grbInicio.Controls.Add(btnRegistro);
            grbInicio.Controls.Add(btnAcceder);
            grbInicio.Controls.Add(lblLogin);
            grbInicio.Controls.Add(btnProbarConexion);
            grbInicio.Controls.Add(lblProbarConexionDB);
            grbInicio.Controls.Add(panel3);
            grbInicio.Controls.Add(chbMostrarContraseña);
            grbInicio.Controls.Add(lblError);
            grbInicio.Controls.Add(panel2);
            grbInicio.Controls.Add(panel1);
            grbInicio.Controls.Add(lblUsuario);
            grbInicio.Controls.Add(txtUsuario);
            grbInicio.Controls.Add(txtContraseña);
            grbInicio.Controls.Add(lblContraseña);
            grbInicio.Location = new Point(11, 9);
            grbInicio.Name = "grbInicio";
            grbInicio.Size = new Size(369, 518);
            grbInicio.TabIndex = 7;
            grbInicio.TabStop = false;
            // 
            // lblMsgError
            // 
            lblMsgError.AutoSize = true;
            lblMsgError.Location = new Point(13, 443);
            lblMsgError.Name = "lblMsgError";
            lblMsgError.Size = new Size(0, 15);
            lblMsgError.TabIndex = 19;
            // 
            // lblRespuestaDB
            // 
            lblRespuestaDB.Location = new Point(21, 99);
            lblRespuestaDB.Name = "lblRespuestaDB";
            lblRespuestaDB.Size = new Size(337, 23);
            lblRespuestaDB.TabIndex = 18;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(7, 386);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(351, 38);
            btnRegistro.TabIndex = 17;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(7, 342);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(351, 38);
            btnAcceder.TabIndex = 16;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // lblLogin
            // 
            lblLogin.Location = new Point(7, 171);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(351, 23);
            lblLogin.TabIndex = 15;
            lblLogin.Text = "Iniciar sesión";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(21, 47);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(337, 30);
            btnProbarConexion.TabIndex = 14;
            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // lblProbarConexionDB
            // 
            lblProbarConexionDB.Location = new Point(21, 24);
            lblProbarConexionDB.Name = "lblProbarConexionDB";
            lblProbarConexionDB.Size = new Size(337, 20);
            lblProbarConexionDB.TabIndex = 13;
            lblProbarConexionDB.Text = "Probar conexión a base de datos";
            lblProbarConexionDB.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.ForeColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(7, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 1);
            panel3.TabIndex = 12;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.FromArgb(255, 77, 89);
            lblError.Location = new Point(7, 342);
            lblError.Name = "lblError";
            lblError.Size = new Size(352, 38);
            lblError.TabIndex = 10;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.ForeColor = SystemColors.ControlDark;
            panel2.Location = new Point(129, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 1);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(129, 245);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1);
            panel1.TabIndex = 6;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.FromArgb(46, 75, 148);
            lblUsuario.Location = new Point(30, 228);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.ForeColor = Color.FromArgb(46, 75, 148);
            lblContraseña.Location = new Point(30, 266);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 539);
            Controls.Add(grbInicio);
            Name = "FrmLogin";
            Text = "Iniciar sesión";
            Load += FrmLogin_Load;
            grbInicio.ResumeLayout(false);
            grbInicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox chbMostrarContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private GroupBox grbInicio;
        private Button btnRegistro;
        private Button btnAcceder;
        private Label lblLogin;
        private Button btnProbarConexion;
        private Label lblProbarConexionDB;
        private Panel panel3;
        private Label lblError;
        private Panel panel2;
        private Panel panel1;
        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblRespuestaDB;
        private Label lblMsgError;
    }
}