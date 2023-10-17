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
    public partial class ABMCliente : Form
    {
        private string accion;
        private Persona cliente;
        private Veterinaria veterinaria;
        private ADO baseDeDatos;
        public ABMCliente(string accion, Persona cliente, Veterinaria veterinaria)
        {
            InitializeComponent();
            this.accion = accion;
            this.cliente = cliente;
            this.veterinaria = veterinaria;
            this.baseDeDatos = new ADO();
        }
        public Persona Cliente { get => this.cliente; } 

        private void ABMCliente_Load(object sender, EventArgs e)
        {
            this.lblTipoAccion.Text = this.accion;
            this.btnAceptar.Text = this.accion;
            this.txtId.Enabled = false;
            this.txtIdVeterinaria.Enabled = false;

            if (this.accion == "Modificar")
            {
                this.txtId.Text = this.cliente.Id.ToString();
                this.txtIdVeterinaria.Text = this.cliente.IdVeterinaria.ToString();
                this.txtNombre.Text = this.cliente.Nombre;
                this.txtApellido.Text = this.cliente.Apellido;
                this.txtDni.Text = this.cliente.Dni.ToString();
            }
            else
            {
                if(this.accion == "Eliminar")
                {
                    this.txtId.Text = this.cliente.Id.ToString();
                    this.txtIdVeterinaria.Text = this.cliente.IdVeterinaria.ToString();
                    this.txtNombre.Text = this.cliente.Nombre;
                    this.txtApellido.Text = this.cliente.Apellido;
                    this.txtDni.Text = this.cliente.Dni.ToString();
                    this.txtApellido.Enabled = false;
                    this.txtNombre.Enabled = false;
                    this.txtDni.Enabled = false;
                }
                this.txtId.Visible = false;
                this.lblId.Visible = false;
                this.txtIdVeterinaria.Text = this.veterinaria.Id.ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.accion == "Eliminar")
            {               
                try
                {
                    bool aux = baseDeDatos.EliminarCliente(int.Parse(txtId.Text));

                    if (aux)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.lblMsg.Text = "No se pudo eliminar al cliente.";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                if (this.accion == "Modificar")
                {
                    Persona aux = new Persona();
                    int id = int.Parse(this.txtId.Text);
                    int idVeterinaria = int.Parse(this.txtIdVeterinaria.Text);
                    string nombre = this.txtNombre.Text;
                    string apellido = this.txtApellido.Text;
                    int dni = int.Parse(this.txtDni.Text);

                    aux.Id = id;
                    aux.IdVeterinaria = idVeterinaria;
                    aux.Nombre = nombre;
                    aux.Apellido = apellido;
                    aux.Dni = dni;

                    bool returnAux = baseDeDatos.ModificarCliente(aux);

                    if (returnAux)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.lblMsg.Text = "No se pudo modificar al cliente.";
                    }
                }
                else
                {
                    if (this.accion == "Agregar")
                    {
                        Persona aux = new Persona();

                        int idVeterinaria = int.Parse(this.txtIdVeterinaria.Text);
                        string nombre = this.txtNombre.Text;
                        string apellido = this.txtApellido.Text;
                        int dni = int.Parse(this.txtDni.Text);

                        aux.IdVeterinaria = idVeterinaria;
                        aux.Nombre = nombre;
                        aux.Apellido = apellido;
                        aux.Dni = dni;

                        bool returnAux = baseDeDatos.AgregarCliente(aux);

                        if (returnAux)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            this.lblMsg.Text = "No se pudo agregar al cliente.";
                        }

                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es una letra y no es la tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es una letra y no es la tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es una letra y no es la tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
        }
    }
}
