using BC_Formularios;
using BibliotecaClases.Eventos;
using static BibliotecaClases.Usuarios_Tarjetas.ClassUsuarios;
using static BC_Formularios.SQL_DataBase.MostrarDatosSql;
using BC_Formularios.SQL_DataBase;

namespace LaboratorioII_BananasCapital
{
    public partial class frmIngresoCreacion : Form
    {
        //VARIABLE GLOBAL//
        public static string? actualUsuario;
        public static string? actualRol;

        //TIEMPO//



        //INSTANCIA//
        private EventosUsuario eventosUsuario;

        public frmIngresoCreacion()
        {
            InitializeComponent();
            eventosUsuario = new EventosUsuario();
            eventosUsuario.DatosCapturados += eventosUsuario.EventosUsuarios;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            DateTime fechaRegistro = DateTime.Now;

            List<TextBox> textboxesCrear = this.panel1.Controls.OfType<TextBox>().ToList();
            foreach (TextBox textbox in textboxesCrear)
            {
                if (textbox.Text == "")
                {
                    MessageBox.Show("El campo " + textbox.Name + " est� vac�o. Por favor, completalo para poder registrarte.");
                    return;
                }
            }

            // TEXT�S BOX//

            string nombre = txtCreacionNombre.Text;
            string apellido = txtCreacionApellido.Text;
            string dni = txtCreacionDNI.Text;
            string cuil = txtCreacionCUIL.Text;
            string celular = txtCreacionCelular.Text;
            string domicilio = txtCreacionDomicilio.Text;
            string nombreUsuario = txtCreacionUsername.Text;
            string contrase�a = txtCreacionContrase�a.Text;
            string correo = txtCreacionCorreo.Text;

            //METODOS// 

            eventosUsuario.CapturarDatosUsuario(nombre, apellido, dni, cuil, celular, domicilio, nombreUsuario, contrase�a, correo);
            MostrarDatosSql guardarRegistro = new MostrarDatosSql();
            //guardarRegistro.guardarUsuarios(txtCreacionDNI, txtCreacionCUIL, txtCreacionCelular, txtCreacionDomicilio, txtCreacionUsername,
            //                txtCreacionContrase�a, txtCreacionCorreo, txtCreacionNombre, txtCreacionApellido);

            // TEXT�S BOX//

            txtCreacionNombre.Text = "";
            txtCreacionApellido.Text = "";
            txtCreacionDNI.Text = "";
            txtCreacionCUIL.Text = "";
            txtCreacionCelular.Text = "";
            txtCreacionDomicilio.Text = "";
            txtCreacionUsername.Text = "";
            txtCreacionContrase�a.Text = "";
            txtCreacionCorreo.Text = "";

        }

        private void btnIniciarIngreso_Click(object sender, EventArgs e)
        {
            string nombreCuenta = txtNombreUsuario.Text;
            string contrase�aCuenta = txtContrase�a.Text;
            string rol;

            User usuario = new();
            if(usuario.Deserializacion(nombreCuenta, contrase�aCuenta, out rol))
            {
                frmMenuApp formulario = new frmMenuApp();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Verifica tus credenciales.");
            }


        }


        private void btnIniciarAdmin_Click(object sender, EventArgs e)
        {

            string nombreCuenta = txtNombreUsuario.Text;
            string contrase�aCuenta = txtContrase�a.Text;
            string rol;

            User usuario = new();
            if (usuario.Deserializacion(nombreCuenta, contrase�aCuenta, out rol))
            {
                frmMenuApp formulario = new frmMenuApp();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Verifica tus credenciales.");
            }

        }

        private void btnIniciarTrial_Click(object sender, EventArgs e)
        {

        }


    }
}