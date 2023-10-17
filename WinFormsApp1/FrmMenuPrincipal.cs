using EntidadesTest;

namespace WinFormsApp1
{
    public partial class FrmMenuPrincipal : Form
    {
        ADO baseDeDatos;
        Archivo<Almacen<Auto>> archivoAlmacenAutos;
        Archivo<Almacen<Moto>> archivoAlmacenMotos;
        Almacen<Auto> almacenDeAutos;
        Almacen<Moto> almacenDeMotos;
        private CancellationToken cancellation;
        private CancellationTokenSource cancellationSource;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.baseDeDatos = new ADO();
            this.archivoAlmacenAutos = new Archivo<Almacen<Auto>>();
            this.archivoAlmacenMotos = new Archivo<Almacen<Moto>>();
            this.almacenDeAutos = new Almacen<Auto>();
            this.almacenDeMotos = new Almacen<Moto>();
            this.cancellationSource = new CancellationTokenSource();
            this.cancellation = this.cancellationSource.Token;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            IniciarHilos();

        }
        private void IniciarHilos()
        {
            Task tareaActualizarListado = Task.Run(() => IniciarProceso(this.dataGridView1));
        }
        private void IniciarProceso(DataGridView dgvTabla)
        {
            this.almacenDeAutos.Lista = baseDeDatos.ObtenerAutos();
            this.almacenDeMotos.Lista = baseDeDatos.ObtenerMotos();

            ActualizarTabla(dgvTabla, this.almacenDeAutos.Lista, this.almacenDeMotos.Lista);
        }
        private void ActualizarTabla(DataGridView dgvTabla, List<Auto> listaAutos, List<Moto> listaMotos)
        {

            if (InvokeRequired)
            {
                Action<DataGridView, List<Auto>,List<Moto>> delegadoActualizarTabla = ActualizarTabla;
                object[] parametros = new object[] { dgvTabla, listaAutos, listaMotos };               
                this.dataGridView1.Invoke(delegadoActualizarTabla, parametros);
            }
            else
            {

                if (this.cancellation.IsCancellationRequested)
                {
                    return;
                }

                foreach (Auto item in listaAutos)
                {
                    this.dataGridView1.Rows.Add(new object[] { item.Id, item.Marca, "----", item.Precio, item.FechaElaboracion, "----", "----"});
                }
                foreach(Moto item in listaMotos)
                {

                    this.dataGridView1.Rows.Add(new object[] { item.Id,"----", item.Modelo, "----", "-----", item.Cilindrada, item.Estado});
                }
            }
        }
    }
}