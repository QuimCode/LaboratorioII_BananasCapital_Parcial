using BibliotecaClases.Usuarios_Tarjetas;
using LaboratorioII_BananasCapital;
using System.Globalization;


namespace BC_Formularios.Menu_App
{
    public partial class frmCartera : Form
    {

        //private frmIngresoCreacion ingresoForm;

        public frmCartera()
        {
            InitializeComponent();
            //ingresoForm = new frmIngresoCreacion();
        }

        private void MenuMercado_Load(object sender, EventArgs e)
        {
            //ingresoForm.UsuarioLogueado += ActualizarUsuarioOperario;
            string usuarioOperario = frmIngresoCreacion.actualUsuario;
            txtUser.Text = usuarioOperario;
            txtUser.ReadOnly = true;

            try
            {
                ClassTarjetaDebito.TarjetaDebito verificacionTarjeta = new ClassTarjetaDebito.TarjetaDebito("Verificacion", usuarioOperario, 0, 0, DateTime.Now);
                bool usuarioTieneTarjeta = verificacionTarjeta.UsuarioTieneTarjetaRegistrada(usuarioOperario);

                if (usuarioTieneTarjeta)
                {
                    MessageBox.Show($"El usuario {usuarioOperario} ya tiene una tarjeta registrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtUsuarioTarjeta.Text = "Ya se ha registrado";
                txtNumeroTarjeta.Text = "Ya se ha registrado";
                txtCCV.Text = "Ya se ha registrado";
                txtVencimiento.Text = "Ya se ha registrado";

                btnRegistro.Enabled = false;
                txtNumeroTarjeta.ReadOnly = true;
                txtUsuarioTarjeta.ReadOnly = true;
                txtCCV.ReadOnly = true;
                txtVencimiento.ReadOnly = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al verificar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //METODO PARA EVENTO//
        //internal void ActualizarUsuarioOperario(string nuevoUsuario)
        //{
        //    txtUser.Text = nuevoUsuario;
        //}

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {

                // Obtener valores de los TextBox
                string nombreApellido = txtUsuarioTarjeta.Text;
                string usuarioOperario = txtUser.Text;
                long numerosTarjeta = long.Parse(txtNumeroTarjeta.Text);
                int codigoTarjeta = int.Parse(txtCCV.Text);
                DateTime fechaVencimiento = DateTime.ParseExact(txtVencimiento.Text, "MM/yyyy", CultureInfo.InvariantCulture);

                // Crear una nueva instancia de TarjetaDebito
                ClassTarjetaDebito.TarjetaDebito nuevaTarjeta = new ClassTarjetaDebito.TarjetaDebito(nombreApellido, usuarioOperario, numerosTarjeta, codigoTarjeta, fechaVencimiento);

                // Guardar la tarjeta en el archivo XML
                nuevaTarjeta.GuardarEnArchivo();

                // Opcional: Puedes realizar otras acciones después de guardar la tarjeta, como mostrar un mensaje de éxito.
                MessageBox.Show("Tarjeta registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso de registro.
                MessageBox.Show($"Error al registrar la tarjeta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }


}
