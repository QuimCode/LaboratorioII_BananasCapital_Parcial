using BibliotecaClases.Eventos;

namespace LaboratorioII_BananasCapital
{
    public partial class frmIngresoCreacion : Form
    {
        private EventosUsuario eventosUsuario;

        public frmIngresoCreacion()
        {
            InitializeComponent();
            eventosUsuario = new EventosUsuario();
            eventosUsuario.DatosCapturados += eventosUsuario.EventDatosCapturados;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // TEXT´S BOX//

            string nombre = txtCreacionNombre.Text;
            string apellido = txtCreacionApellido.Text;
            string dni = txtCreacionDNI.Text;
            string cuil = txtCreacionCUIL.Text;
            string celular = txtCreacionCelular.Text;
            string domicilio = txtCreacionDomicilio.Text;
            string nombreUsuario = txtCreacionUsername.Text;
            string contraseña = txtCreacionContraseña.Text;
            string correo = txtCreacionCorreo.Text;

            //METODOS// 

            eventosUsuario.CapturarDatosUsuario(nombre, apellido, dni, cuil, celular, domicilio, nombreUsuario, contraseña, correo);

            // TEXT´S BOX//

            txtCreacionNombre.Text = "";
            txtCreacionApellido.Text = "";
            txtCreacionDNI.Text = "";
            txtCreacionCUIL.Text = "";
            txtCreacionCelular.Text = "";
            txtCreacionDomicilio.Text = "";
            txtCreacionUsername.Text = "";
            txtContraseña.Text = "";
            txtCreacionCorreo.Text = "";

        }
    }
}