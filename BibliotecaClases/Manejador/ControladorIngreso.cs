using static BibliotecaClases.Usuarios_Tarjetas.ClassUsuarios;
using System.Text.Json;

namespace BibliotecaClases.Manejador
{
    public class ControladorIngreso
    {
        public bool ValidarLogin(string usuario, string contraseña, out string rol)
        {
            string ArchivoUsuarios = @"C:\Users\quima\OneDrive\Escritorio";

            var usuarios = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(ArchivoUsuarios));

            // Iterar sobre la lista de usuarios
            foreach (var usuarioJson in usuarios)
            {
                // Verificar si el usuario y la contraseña coinciden
                if (usuarioJson.Username == usuario && usuarioJson.Contraseña == contraseña)
                {
                    // Los datos de login son correctos
                    rol = usuarioJson.Rol;
                    return true;
                }
            }

            // Los datos de login son incorrectos
            rol = null;
            return false;
        }

    }
}
