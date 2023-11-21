using System.Text.Json;
using static BibliotecaClases.Interfaces.InterfazSerializacion;

namespace BibliotecaClases.Usuarios_Tarjetas
{
    public class ClassUsuarios
    {
        // CLASE ABSTRACTA PADRE //

        public abstract class Persona
        {
            public string? Nombre { get; set; }
            public string? Apellido { get; set; }
            public string? Rol { get; set; }
            public decimal Saldo { get; set; } = 0;

        }

        // CLASE HEREDADA DE PERSONA //

        public class User : Persona, ISerializacion<User>
        {
            private const string ArchivoUsuarios = "UsuariosDataBase.json";

            //private static string _actualUsuario;

            //public static string ActualUsuario
            //{
            //    get { return _actualUsuario; }
            //    set { _actualUsuario = value; }
            //}

            //ATRIBUTOS//

            public string DNI { get; set; }
            public string Cuit_Cuil { get; set; }
            public string Celular { get; set; }
            public string Domicilio { get; set; }
            public string Username { get; set; }
            public string Contraseña { get; set; }
            public string Email { get; set; }
            public int CantidadAcciones { get; set; } = 0;

            //CONSTRUCTOR//

            public User(string nombreU, string apellidoU, string dniU, string cuit_cuilU, string celularU, string domicilioU,
             string usernameU, string contraseñaU, string emailU)
            {
                Nombre = nombreU;
                Apellido = apellidoU;
                DNI = dniU;
                Cuit_Cuil = cuit_cuilU;
                Celular = celularU;
                Domicilio = domicilioU;
                Username = usernameU;
                Contraseña = contraseñaU;
                Email = emailU;
                Saldo = 0;
                Rol = "Usuario";
            }

            //CONTRATO//

            public string Serializacion(User objeto)
            {
                return JsonSerializer.Serialize(objeto, new JsonSerializerOptions { WriteIndented = true });
            }

            public User Deserializacion(string datos)
            {
                return JsonSerializer.Deserialize<User>(datos);
            }

            public void GuardarEnArchivo()
            {
                // Serializar el usuario a JSON
                string usuarioJson = Serializacion(this);

                // Guardar el JSON en un archivo sin sobrescribir (AppendAllText)
                File.AppendAllText(ArchivoUsuarios, usuarioJson + Environment.NewLine);
            }

        }

        // CLASES HEREDADAS DE USER  //

        public class UserTrial : User
        {
            private const string ArchivoUsuarios = "UsuariosDataBase.json";

            public UserTrial()
                : base("UserTrial", "trial", "TRIAL", "TRIAL", "TRIAL", "TRIAL", "TRIAL", "TRIAL", "TRIAL")
            {
                Rol = "UsuarioTrial";
                Saldo = 500000;
            }

            //CONTRATO//
            public string Serializacion(User objeto)
            {
                return JsonSerializer.Serialize(objeto, new JsonSerializerOptions { WriteIndented = true });
            }

            public User Deserializacion(string datos)
            {
                return JsonSerializer.Deserialize<User>(datos);
            }

            public void GuardarEnArchivo()
            {
                // Serializar el usuario a JSON
                string usuarioJson = Serializacion(this);

                // Guardar el JSON en un archivo sin sobrescribir (AppendAllText)
                File.AppendAllText(ArchivoUsuarios, usuarioJson + Environment.NewLine);
            }
        }

        public class Admin : User
        {
            private const string ArchivoUsuarios = "UsuariosDataBase.json";

            public Admin()
                : base("UserAdmin", "admin", "ADMIN", "ADMIN", "ADMIN", "ADMIN", "ADMIN", "ADMIN", "ADMIN")
            {
                Rol = "UsuarioAdministrador";
                Saldo = 500000;
            }

            //CONTRATO//
            public string Serializacion(User objeto)
            {
                return JsonSerializer.Serialize(objeto, new JsonSerializerOptions { WriteIndented = true });
            }

            public User Deserializacion(string datos)
            {
                return JsonSerializer.Deserialize<User>(datos);
            }

            public void GuardarEnArchivo()
            {
                // Serializar el usuario a JSON
                string usuarioJson = Serializacion(this);

                // Guardar el JSON en un archivo sin sobrescribir (AppendAllText)
                File.AppendAllText(ArchivoUsuarios, usuarioJson + Environment.NewLine);
            }
        }

    }
}