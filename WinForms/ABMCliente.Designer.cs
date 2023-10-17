namespace WinForms
{
    partial class ABMCliente
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
            lblId = new Label();
            lblIdVeterinaria = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblTipoAccion = new Label();
            txtId = new TextBox();
            txtIdVeterinaria = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDni = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(17, 107);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblIdVeterinaria
            // 
            lblIdVeterinaria.AutoSize = true;
            lblIdVeterinaria.Location = new Point(17, 133);
            lblIdVeterinaria.Name = "lblIdVeterinaria";
            lblIdVeterinaria.Size = new Size(76, 15);
            lblIdVeterinaria.TabIndex = 1;
            lblIdVeterinaria.Text = "ID veterinaria";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 160);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(17, 186);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(17, 215);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI";
            // 
            // lblTipoAccion
            // 
            lblTipoAccion.AutoSize = true;
            lblTipoAccion.Location = new Point(12, 9);
            lblTipoAccion.Name = "lblTipoAccion";
            lblTipoAccion.Size = new Size(0, 15);
            lblTipoAccion.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(169, 107);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // txtIdVeterinaria
            // 
            txtIdVeterinaria.Location = new Point(169, 133);
            txtIdVeterinaria.Name = "txtIdVeterinaria";
            txtIdVeterinaria.Size = new Size(100, 23);
            txtIdVeterinaria.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(169, 186);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 9;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 160);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(169, 215);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 10;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 300);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "accion";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(213, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(13, 251);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 15);
            lblMsg.TabIndex = 13;
            // 
            // ABMCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 335);
            Controls.Add(lblMsg);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtIdVeterinaria);
            Controls.Add(txtId);
            Controls.Add(lblTipoAccion);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblIdVeterinaria);
            Controls.Add(lblId);
            Name = "ABMCliente";
            Text = "ABMCliente";
            Load += ABMCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblIdVeterinaria;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblTipoAccion;
        private TextBox txtId;
        private TextBox txtIdVeterinaria;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDni;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblMsg;
    }
}