using BibliotecaClases.Usuarios_Tarjetas;

namespace BibliotecaClases.Eventos
{
    public class EventosUsuario
    {
        
        public event EventHandler<ClassUsuarios.User> DatosCapturados;
        public event EventHandler<ClassUsuarios.User> DatosCapturados2;

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
            // Verificar si hay suscriptores al evento
            DatosCapturados?.Invoke(this, usuario);
        }

        public void EventDatosCapturados(object sender, ClassUsuarios.User usuario)
        {
            usuario.Serializacion(usuario);
            usuario.GuardarEnArchivo();
        }

    }
}
