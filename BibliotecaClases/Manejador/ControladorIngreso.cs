using static BibliotecaClases.Usuarios_Tarjetas.ClassUsuarios;
using System.Text.Json;

namespace BibliotecaClases.Manejador
{
    public class ControladorIngreso
    {
        public bool ValidarLogin(string usuario, string contraseña, out string rol)
        {
            string ArchivoUsuarios = @"E:\Progra - Labo II\LaboratorioII_BananasCapital_Parcial\LaboratorioII_BananasCapital\bin\Debug\net6.0
                                     - windows";

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
