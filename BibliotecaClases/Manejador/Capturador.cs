using BibliotecaClases.Usuarios_Tarjetas;

namespace BibliotecaClases.Manejador
{
    internal class Capturador
    {
        public static ClassUsuarios.User CapturarDatosUsuario(string nombre, string apellido, string dni, string cuit_cuil, string celular,
                                                              string domicilio, string username, string contraseña, string email)
        {
            // Aquí puedes realizar validaciones o cualquier lógica adicional antes de crear el usuario
            ClassUsuarios.User nuevoUsuario = new ClassUsuarios.User(nombre, apellido, dni, cuit_cuil, celular, 
                                                                     domicilio, username, contraseña, email);
            return nuevoUsuario;
        }
    }
}
