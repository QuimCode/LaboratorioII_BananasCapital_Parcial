using System.Text.Json;
using static BibliotecaClases.Interfaces.InterfazSerializacion;

namespace BibliotecaClases.Usuarios_Tarjetas
{
    public class ClassUsuarios
    {
        // CLASE ABSTRACTA PADRE //

        public abstract class Persona : ISerializacionJson
        {
            public string? Nombre { get; set; }
            public string? Apellido { get; set; }
            public string? Rol { get; set; }
            public decimal Saldo { get; set; } = 0;

            public string SerializacionDeJson()
            {
                return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            }

            public void DeserializacionDelJson(string nombreJson)
            {
                var deserializedPersona = JsonSerializer.Deserialize<Persona>(jsonString);
            }

        }

        // CLASE HEREDADA DE PERSONA //

        public class User : Persona
        {
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

        }

        // CLASES HEREDADAS DE USER  //

        public class UserTrial : User
        {
            public UserTrial()
                : base("UserTrial", "trial", "TRIAL", "TRIAL", "TRIAL", "TRIAL", "TRIAL", "TRIAL", "TRIAL")
            {
                Rol = "UsuarioTrial";
                Saldo = 500000;
            }
        }

        public class Admin : User
        {
            public Admin()
                : base("UserAdmin", "admin", "ADMIN", "ADMIN", "ADMIN", "ADMIN", "ADMIN", "ADMIN", "ADMIN")
            {
                Rol = "UsuarioAdministrador";
                Saldo = 500000;
            }
        }

    }
}