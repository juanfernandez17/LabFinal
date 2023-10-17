using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class lblMsg1 : Form
    {
        ADO baseDeDatos;
        Veterinaria veterinaria;
        List<Persona> listaClientes;
        private CancellationToken cancellation;
        private CancellationTokenSource cancellationSource;
        private Temporizador temporizador;

        public lblMsg1()
        {
            InitializeComponent();
            baseDeDatos = new ADO();
            veterinaria = new Veterinaria("Pichichus", 1);
            listaClientes = new List<Persona>();
            this.cancellationSource = new CancellationTokenSource();
            this.cancellation = this.cancellationSource.Token;
            this.temporizador = new Temporizador(1000);
            this.temporizador.TiempoCumplido += AsignarHora;
        }

        private void lblMsg1_Load(object sender, EventArgs e)
        {
            IniciarHilos();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Persona aux = new Persona();
            ABMCliente frmABMCliente = new ABMCliente("Agregar", aux, this.veterinaria);
            DialogResult dialogResult = frmABMCliente.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                this.veterinaria += frmABMCliente.Cliente;
                this.lblMensajeRetorno.Text = "Se agrego al cliente de manera exitosa.";
            }
            else
            {
                this.lblMensajeRetorno.Text = "No se agrego clientes.";
            }
            this.LimpiarTabla();
            this.IniciarHilos();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Persona aux = new Persona();

            int rowSelected = this.dataGridView1.CurrentRow.Index;
            int index = -1;

            aux.Id = (int)(this.dataGridView1[0, rowSelected].Value);
            aux.IdVeterinaria = (int)(this.dataGridView1[1, rowSelected].Value);
            aux.Nombre = this.dataGridView1[2, rowSelected].Value.ToString();
            aux.Apellido = this.dataGridView1[3, rowSelected].Value.ToString();
            aux.Dni = (int)this.dataGridView1[4, rowSelected].Value;

            ABMCliente frmABMCliente = new ABMCliente("Modificar", aux, this.veterinaria);
            DialogResult dialogResult = frmABMCliente.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                index = this.veterinaria.BuscarClientePorId(aux.Id);
                this.veterinaria.ListaClientes[index] = aux;
                this.lblMensajeRetorno.Text = "Se modificó al cliente de manera exitosa.";
            }
            else
            {
                this.lblMensajeRetorno.Text = "No se modificó clientes.";
            }

            this.LimpiarTabla();
            this.IniciarHilos();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Persona aux = new Persona();

            int rowSelected = this.dataGridView1.CurrentRow.Index;
            int index = -1;

            aux.Id = (int)(this.dataGridView1[0, rowSelected].Value);
            aux.IdVeterinaria = (int)(this.dataGridView1[1, rowSelected].Value);
            aux.Nombre = this.dataGridView1[2, rowSelected].Value.ToString();
            aux.Apellido = this.dataGridView1[3, rowSelected].Value.ToString();
            aux.Dni = (int)this.dataGridView1[4, rowSelected].Value;

            ABMCliente frmABMCliente = new ABMCliente("Eliminar", aux, this.veterinaria);
            DialogResult dialogResult = frmABMCliente.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                index = this.veterinaria.BuscarClientePorId(aux.Id);
                this.veterinaria -= this.veterinaria.ListaClientes[index];
                this.lblMensajeRetorno.Text = "Se eliminó al cliente de manera exitosa.";
            }
            else
            {
                this.lblMensajeRetorno.Text = "No se eliminó clientes.";
            }
            this.LimpiarTabla();
            this.IniciarHilos();
        }

        private void IniciarHilos()
        {
            Task tareaActualizarListado = Task.Run(() => IniciarProceso(this.dataGridView1));
        }

        private void IniciarProceso(DataGridView dgvTabla)
        {
            this.listaClientes = baseDeDatos.ObtenerClientesPorVeterinaria(veterinaria.Id);
            this.veterinaria.ListaClientes = listaClientes;

            ActualizarTabla(dgvTabla, listaClientes);
        }

        private void ActualizarTabla(DataGridView dgvTabla, List<Persona> listaClientes)
        {

            if (InvokeRequired)
            {
                Action<DataGridView, List<Persona>> delegadoActualizarTabla = ActualizarTabla;
                object[] parametros = new object[] { dgvTabla, listaClientes };
                // ActualizarTabla(dgvTabla, listaClientes);
                this.dataGridView1.Invoke(delegadoActualizarTabla, parametros);
            }
            else
            {

                if (this.cancellation.IsCancellationRequested)
                {
                    return;
                }

                foreach (Persona item in listaClientes)
                {
                    this.dataGridView1.Rows.Add(new object[] { item.Id, item.IdVeterinaria, item.Nombre, item.Apellido, item.Dni });
                }
            }
        }

        private void btnConsultarMascotas_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarTabla()
        {
            dataGridView1.Rows.Clear();
            //this.dataGridView1.DataSource = null;
        }


        // ---- EVENTOS
        private void AsignarHora()
        {
            if(InvokeRequired)
            {
                Action asignarHora = AsignarHora;
                this.label1.Invoke(asignarHora);
            }
            else
            {
                if(this.cancellation.IsCancellationRequested)
                {
                    return;
                }
                this.label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
           
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.temporizador.IniciarTemporizador();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            this.temporizador.DetenerTemporizador();
        }
        
    }
}
