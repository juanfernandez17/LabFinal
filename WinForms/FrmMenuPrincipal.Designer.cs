namespace WinForms
{
    partial class lblMsg1
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            idVeterinaria = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            panelClientes = new Panel();
            btnAgregarCliente = new Button();
            btnModificarCliente = new Button();
            btnEliminarCliente = new Button();
            btnConsultarMascotas = new Button();
            lblMensajeRetorno = new Label();
            lblHora = new Label();
            btnIniciar = new Button();
            btnDetener = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelClientes.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(140, 242, 142);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, idVeterinaria, nombre, apellido, dni });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(199, 248, 208);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(677, 393);
            dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            id.FillWeight = 25.38071F;
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // idVeterinaria
            // 
            idVeterinaria.FillWeight = 118.654823F;
            idVeterinaria.HeaderText = "N° Sucursal Veterinaria";
            idVeterinaria.Name = "idVeterinaria";
            idVeterinaria.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.FillWeight = 118.654823F;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.FillWeight = 118.654823F;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // dni
            // 
            dni.FillWeight = 118.654823F;
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // panelClientes
            // 
            panelClientes.Controls.Add(dataGridView1);
            panelClientes.Location = new Point(12, 45);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(677, 393);
            panelClientes.TabIndex = 2;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(695, 72);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(171, 23);
            btnAgregarCliente.TabIndex = 3;
            btnAgregarCliente.Text = "Agregar cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(695, 101);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(171, 23);
            btnModificarCliente.TabIndex = 4;
            btnModificarCliente.Text = "Modificar cliente";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(695, 130);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(171, 23);
            btnEliminarCliente.TabIndex = 5;
            btnEliminarCliente.Text = "Eliminar cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnConsultarMascotas
            // 
            btnConsultarMascotas.Location = new Point(695, 390);
            btnConsultarMascotas.Name = "btnConsultarMascotas";
            btnConsultarMascotas.Size = new Size(171, 48);
            btnConsultarMascotas.TabIndex = 6;
            btnConsultarMascotas.Text = "Consultar mascotas del cliente";
            btnConsultarMascotas.UseVisualStyleBackColor = true;
            btnConsultarMascotas.Click += btnConsultarMascotas_Click;
            // 
            // lblMensajeRetorno
            // 
            lblMensajeRetorno.AutoSize = true;
            lblMensajeRetorno.Location = new Point(699, 183);
            lblMensajeRetorno.Name = "lblMensajeRetorno";
            lblMensajeRetorno.Size = new Size(0, 15);
            lblMensajeRetorno.TabIndex = 7;
            lblMensajeRetorno.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(520, 13);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(38, 15);
            lblHora.TabIndex = 8;
            lblHora.Text = "label2";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(614, 5);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 9;
            btnIniciar.Text = "Iniciar reloj";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(699, 5);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(100, 23);
            btnDetener.TabIndex = 10;
            btnDetener.Text = "Detener reloj";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // lblMsg1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 450);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(lblHora);
            Controls.Add(lblMensajeRetorno);
            Controls.Add(btnConsultarMascotas);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(panelClientes);
            Controls.Add(label1);
            Name = "lblMsg1";
            Text = "Menu principal";
            Load += lblMsg1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelClientes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn idVeterinaria;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private Panel panelClientes;
        private Button btnAgregarCliente;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
        private Button btnConsultarMascotas;
        private Label lblMensajeRetorno;
        private Label lblHora;
        private Button btnIniciar;
        private Button btnDetener;
    }
}