using Entidades;

namespace WinForms
{
    public partial class FrmLogin : Form
    {
        ADO baseDeDatos;
        public FrmLogin()
        {
            InitializeComponent();
            baseDeDatos = new ADO();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Enabled = false;
            this.txtContrase�a.Enabled = false;
            this.btnAcceder.Enabled = false;
            this.btnRegistro.Enabled = false;
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            bool aux;

            try
            {
                aux = baseDeDatos.ProbarConexion();
                if (aux)
                {
                    this.txtUsuario.Enabled = true;
                    this.txtContrase�a.Enabled = true;
                    this.btnAcceder.Enabled = true;
                    this.btnRegistro.Enabled = true;
                    this.lblRespuestaDB.Text = "Conexi�n a base de datos exitosa. Puede continuar.";
                }
                else
                {
                    this.lblRespuestaDB.Text = "Conexi�n a base de datos erronea. Debe solucionar el problema para poder continuar.";
                }
            }
            catch (Exception)
            {
                this.lblRespuestaDB.Text = "Conexi�n a base de datos erronea. Debe solucionar el problema para poder continuar.";
            }



        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string contrasenia = this.txtContrase�a.Text;
            Administrador aux = null;

            if (!(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia)))
            {
                try
                {
                    aux = baseDeDatos.VerificarInicioSesion(usuario, contrasenia);

                    if (aux is not null)
                    {
                        this.lblMsgError.Text = "Acceso correcto.";
                        lblMsg1 frmMenuPrincipal = new lblMsg1();
                        this.Hide();
                        frmMenuPrincipal.ShowDialog();
                    }
                    else
                    {
                        this.lblMsgError.Text = "Usuario y/o contrase�a incorrecto.";
                    }
                }
                catch (Exception)
                {
                    this.lblMsgError.Text = "Error al acceder a los datos.";
                }
            }
            else
            {
                this.lblMsgError.Text = "Debe ingresar el usuario y contrase�a.";
            }
        }

        private void chbMostrarContrase�a_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbMostrarContrase�a.Checked)
            {
                this.txtContrase�a.PasswordChar = '\0';
            }
            else
            {
                this.txtContrase�a.PasswordChar = '*';
            }
            txtContrase�a.Focus();
        }

        
    }
}