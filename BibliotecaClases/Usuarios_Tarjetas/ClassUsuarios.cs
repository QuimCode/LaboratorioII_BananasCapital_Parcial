using System.Text.Json;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
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

            //ATRIBUTOS//
            public DateTime FechaRegistro { get; set; }
            public string Username { get; set; }
            public string Contraseña { get; set; }
            public string Email { get; set; }
            public string DNI { get; set; }
            public string Cuit_Cuil { get; set; }
            public string Celular { get; set; }
            public string Domicilio { get; set; }
            public int CantidadAcciones { get; set; } = 0;

            //CONSTRUCTOR//
            public User(string nombreU, string apellidoU, string usernameU, string contraseñaU, string emailU,
                        string dniU, string cuit_cuilU, string celularU, string domicilioU)
            {
                Nombre = nombreU;
                Apellido = apellidoU;
                Rol = "Usuario";
                Username = usernameU;
                Contraseña = contraseñaU;
                Email = emailU;
                DNI = dniU;
                Cuit_Cuil = cuit_cuilU;
                Celular = celularU;
                Domicilio = domicilioU;
                Saldo = 0;
            }

            public User()
            {
            }

            //CONTRATO//

            public string Serializacion(List<User> objetos)
            {
                var opcionesSerializacion = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };

                var usuariosOrdenados = objetos.Select(u => new
                {
                    u.Nombre,
                    u.Apellido,
                    u.Rol,
                    u.FechaRegistro,
                    u.Username,
                    u.Contraseña,
                    u.Email,
                    u.DNI,
                    u.Cuit_Cuil,
                    u.Celular,
                    u.Domicilio,
                    u.CantidadAcciones,
                    u.Saldo
                }).ToList();

                return JsonSerializer.Serialize(usuariosOrdenados, opcionesSerializacion);
            }


            public User Deserializacion(string datos)
            {
                return JsonSerializer.Deserialize<User>(datos);
            }

            public bool Deserializacion(string usuario, string contraseña, out string rol)
            {
                var usuarios = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(ArchivoUsuarios));

                foreach (var usuarioJson in usuarios)
                {
                    if (usuarioJson.Username == usuario && usuarioJson.Contraseña == contraseña)
                    {
                        rol = usuarioJson.Rol;
                        return true;
                    }
                }

                rol = null;
                return false;
            }

            public void GuardarEnArchivo()
            {
                FechaRegistro = DateTime.Now;

                VerificacionAdminTrial();

                List<User> usuarios;

                try
                {
                    string usuariosJson = File.ReadAllText(ArchivoUsuarios);
                    usuarios = JsonSerializer.Deserialize<List<User>>(usuariosJson);
                }
                catch (FileNotFoundException)
                {
                    usuarios = new List<User>();
                }

                usuarios.Add(this);

                string usuariosJsonUpdated = Serializacion(usuarios);
                File.WriteAllText(ArchivoUsuarios, usuariosJsonUpdated);

                Task.Run(() => GenerarInformePDF());
            }


            public async Task GenerarInformePDF()
            {
                await Task.Run(() =>
                {
                    string filePath = "InformeUsuario.pdf";

                    using (var writer = new PdfWriter(filePath))
                    {
                        using (var pdf = new PdfDocument(writer))
                        {

                            var document = new Document(pdf);
                            document.Add(new Paragraph("******* Informe de Usuarios Registrados *******"));

                            foreach (var user in ObtenerUsuariosRegistrados())
                            {
                                string mensaje = $"Se registró {user.Nombre} el {user.FechaRegistro:dd/MM/yyyy} a las {user.FechaRegistro:HH:mm:ss}";
                                document.Add(new Paragraph(mensaje));
                            }

                        }
                    }
                    Thread.Sleep(10000);

                    {

                    }

                });
            }

            private List<User> ObtenerUsuariosRegistrados()
            {
                try
                {
                    string usuariosJson = File.ReadAllText(ArchivoUsuarios);
                    return JsonSerializer.Deserialize<List<User>>(usuariosJson);
                }
                catch (FileNotFoundException)
                {
                    return new List<User>();
                }
            }

            public void VerificacionAdminTrial()
            {
                bool adminExists = UsuarioExiste("UsuarioAdministrador");
                bool trialExists = UsuarioExiste("UsuarioTrial");

                if (!adminExists || !trialExists)
                {
                    List<User> usuarios;

                    try
                    {
                        string usuariosJson = File.ReadAllText(ArchivoUsuarios);
                        usuarios = JsonSerializer.Deserialize<List<User>>(usuariosJson);
                    }
                    catch (FileNotFoundException)
                    {
                        usuarios = new List<User>();
                    }

                    if (!adminExists)
                    {
                        Admin userAdmin = new Admin();
                        usuarios.Add(userAdmin);
                    }

                    if (!trialExists)
                    {
                        UserTrial userTrial = new UserTrial();
                        usuarios.Add(userTrial);
                    }

                    string usuariosJsonUpdated = Serializacion(usuarios);
                    File.WriteAllText(ArchivoUsuarios, usuariosJsonUpdated);
                }
            }

            public bool UsuarioExiste(string rol)
            {
                List<User> usuarios;

                try
                {

                    string usuariosJson = File.ReadAllText(ArchivoUsuarios);
                    usuarios = JsonSerializer.Deserialize<List<User>>(usuariosJson);
                }
                catch (FileNotFoundException)
                {

                    return false;
                }


                return usuarios.Any(u => u.Rol == rol);
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

        //METODOS//



    }
}