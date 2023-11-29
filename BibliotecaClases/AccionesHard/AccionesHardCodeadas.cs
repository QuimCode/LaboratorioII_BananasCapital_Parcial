using MySql.Data.MySqlClient;
using System.Data;


namespace BibliotecaClases.AccionesHard
{
    public class Acciones
    {

        public class Accion
        {
            public string NombreAccion { get; set; }
            private decimal _precioAlta;
            public decimal PrecioAlta
            {
                get { return _precioAlta; }
                set { _precioAlta = Math.Max(value, 5); }
            }
            private decimal _precioBaja;
            public decimal PrecioBaja
            {
                get { return _precioBaja; }
                set { _precioBaja = Math.Max(value, 5); }
            }
            public int Cantidad { get; set; }

            public Accion(string nombreAccion, decimal precioAlta, decimal precioBaja, int cantidad)
            {
                NombreAccion = nombreAccion;
                PrecioAlta = precioAlta;
                PrecioBaja = precioBaja;
                Cantidad = cantidad;
            }
        }

        public class AccionesHardCodeadas
        {
            public static List<Accion> CrearAccionesHard()
            {
                List<Accion> acciones = new List<Accion>();

                acciones.Add(new Accion("AAPL", 138.40m, 2.38m, 132));
                acciones.Add(new Accion("GOOGL", 2568.99m, 2510.50m, 250));
                acciones.Add(new Accion("MSFT", 305.45m, 299.87m, 180));
                acciones.Add(new Accion("TSLA", 780.25m, 760.50m, 150));
                acciones.Add(new Accion("AMZN", 3450.75m, 3425.00m, 300));
                acciones.Add(new Accion("NFLX", 590.60m, 580.25m, 120));
                acciones.Add(new Accion("FB", 340.85m, 336.40m, 220));
                acciones.Add(new Accion("GOOG", 2720.15m, 2685.50m, 280));
                acciones.Add(new Accion("NVDA", 250.75m, 245.90m, 160));
                acciones.Add(new Accion("AAP", 185.30m, 182.15m, 180));
                acciones.Add(new Accion("GM", 60.75m, 58.90m, 220));
                acciones.Add(new Accion("CSCO", 45.25m, 44.10m, 150));
                acciones.Add(new Accion("IBM", 120.45m, 119.20m, 100));
                acciones.Add(new Accion("ORCL", 80.60m, 79.35m, 130));
                acciones.Add(new Accion("INTC", 55.75m, 54.60m, 190));

                return acciones;
            }
            //Controlador guardarAcciones = new Controlador();
            //guardarAcciones.Guardar(acciones);
        }

        public static bool ArchivoExiste(string rutaArchivo)
        {
            return File.Exists(rutaArchivo);
        }

        public static void ActualizarPrecios(List<Accion> acciones, string cadenaConexion)
        {
            Random random = new Random();

            while (true)
            {
                // Actualizar precios aleatorios cada 10 segundos
                foreach (var accion in acciones)
                {
                    // Actualizar PrecioAlta
                    accion.PrecioAlta = Math.Round(accion.PrecioAlta + (decimal)(random.NextDouble() * 10), 2);

                    // Actualizar PrecioBaja
                    double probabilidad = random.NextDouble();
                    if (probabilidad < 0.6)
                    {
                        // Probabilidad del 60%
                        accion.PrecioBaja = Math.Round(accion.PrecioAlta * 0.9m, 2); // 10% menos
                    }
                    else
                    {
                        // Probabilidad del 40%
                        accion.PrecioBaja = Math.Round(accion.PrecioAlta * 1.2m, 2); // 20% más
                    }

                    // Asegurar que PrecioBaja sea menor que PrecioAlta
                    accion.PrecioBaja = Math.Min(accion.PrecioBaja, accion.PrecioAlta);

                    accion.Cantidad = random.Next(100, 500);
                }

                // Puedes agregar aquí la lógica para actualizar los precios en la base de datos
                ConexionDataBaseSql2.InsertarAccionesEnBaseDeDatos(acciones);
  

                // Simular espera de 10 segundos
                Thread.Sleep(10000);
            }
        }

        public class ConexionDataBaseSql2
        {
            static MySqlConnection ConexionBD = new MySqlConnection();

            static string servidor = "localhost";
            static string nombreBD = "bananascapital";
            static string usuario = "root";
            static string contraseña = "S1vw06vf";
            static string puerto = "3306";

            static string conexionDeCadena = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "UserId=" + usuario + ";" + "Password=" + contraseña + ";" + "Database=" + nombreBD + ";";

            public static MySqlConnection EstablecerConexion()
            {
                try
                {
                    ConexionBD.ConnectionString = conexionDeCadena;
                    ConexionBD.Open();
                }
                catch (MySqlException ex)
                {
                    // Manejo de excepciones
                }

                return ConexionBD;
            }

            public static void CerrarConexion()
            {
                if (ConexionBD.State == ConnectionState.Open)
                {
                    ConexionBD.Close();
                }
            }

            public static void InsertarAccionesEnBaseDeDatos(List<Accion> acciones)
            {
                MySqlConnection connection = null;

                try
                {
                    connection = EstablecerConexion();

                    foreach (var accion in acciones)
                    {
                        if (!ExisteAccionEnBaseDeDatos(accion.NombreAccion, connection))
                        {
                            string query = "INSERT INTO accionesbananas (NombreAccion, PrecioAlta, PrecioBaja, Cantidad) " +
                                           "VALUES (@NombreAccion, @PrecioAlta, @PrecioBaja, @Cantidad)";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@NombreAccion", accion.NombreAccion);
                                command.Parameters.AddWithValue("@PrecioAlta", accion.PrecioAlta);
                                command.Parameters.AddWithValue("@PrecioBaja", accion.PrecioBaja);
                                command.Parameters.AddWithValue("@Cantidad", accion.Cantidad);

                                command.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Acción con el mismo nombre ya existe, puedes manejarlo según tus necesidades (por ejemplo, ignorarla o actualizarla)
                            Console.WriteLine($"La acción '{accion.NombreAccion}' ya existe en la base de datos.");
                        }
                    }
                }
                finally
                {
                    CerrarConexion();
                }
            }

            private static bool ExisteAccionEnBaseDeDatos(string nombreAccion, MySqlConnection connection)
            {
                string query = "SELECT COUNT(*) FROM accionesbananas WHERE NombreAccion = @NombreAccion";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreAccion", nombreAccion);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }

        }





    }
}

