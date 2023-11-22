using BibliotecaClases.Usuarios_Tarjetas;

namespace BibliotecaClases.Eventos
{
    public class EventosUsuario
    {

        public event EventHandler<ClassUsuarios.User> DatosCapturados;


        public ClassUsuarios.User CapturarDatosUsuario(string nombre, string apellido, string dni, string cuit_cuil, string celular,
                                                              string domicilio, string username, string contraseña, string email)
        {

            ClassUsuarios.User nuevoUsuario = new ClassUsuarios.User(nombre, apellido, dni, cuit_cuil, celular,
                                                                     domicilio, username, contraseña, email);
            OnDatosCapturados(nuevoUsuario);
            return nuevoUsuario;

        }

        protected virtual void OnDatosCapturados(ClassUsuarios.User usuario)
        {
            DatosCapturados?.Invoke(this, usuario);
        }

        public void EventosUsuarios(object sender, ClassUsuarios.User usuario)
        {
            List<ClassUsuarios.User> listaUsuarios = new List<ClassUsuarios.User> { usuario };

            string usuariosJson = usuario.Serializacion(listaUsuarios);
            usuario.GuardarEnArchivo();
        }

    }
}
