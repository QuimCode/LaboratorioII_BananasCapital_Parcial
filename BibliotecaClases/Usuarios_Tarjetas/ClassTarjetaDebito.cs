using static BibliotecaClases.Interfaces.InterfazSerializacion;
using System.Xml.Serialization;

namespace BibliotecaClases.Usuarios_Tarjetas
{
    public class ClassTarjetaDebito
    {

        public class TarjetaDebito : ITarjetaDebitoSerializacion
        {
            internal const string ArchivoTarjetas = "TarjetasDataBase.xml";

            //ATRIBUTOS//
            public string Titular { get; set; }
            public string UsuarioOperario { get; set; }
            public long NumeroTarjeta { get; set; }
            public int CodigoSeguridad { get; set; }
            public DateTime FechaVencimiento { get; set; }
            public decimal Saldo { get; set; }

            //CONSTRUCTOR//

            public TarjetaDebito(string nombredueño, string usuarioOpera, long numerodetarjeta, int cvvdetarjeta, DateTime vencimientodetarjeta)

            {
                Titular = nombredueño;
                UsuarioOperario = usuarioOpera;
                NumeroTarjeta = numerodetarjeta;
                CodigoSeguridad = cvvdetarjeta;
                FechaVencimiento = vencimientodetarjeta;
                Saldo = 10000;
            }

            //COMPATIBILIDAD XML//

            [XmlRoot("TarjetaData")]
            public class TarjetaData
            {
                [XmlElement("Titular")]
                public string Titular { get; set; }

                [XmlElement("UsuarioOperario")]
                public string UsuarioOperario { get; set; }

                [XmlElement("NumeroTarjeta")]
                public long NumeroTarjeta { get; set; }

                [XmlElement("CodigoSeguridad")]
                public int CodigoSeguridad { get; set; }

                [XmlElement("FechaVencimiento")]
                public DateTime FechaVencimiento { get; set; }

                [XmlElement("Saldo")]
                public decimal Saldo { get; set; }
            }

            //CONTRATO//
            public string Serializacion(Dictionary<long, TarjetaDebito> objetos)
            {
                var listaTarjetasData = new List<TarjetaData>();
                foreach (var tarjeta in objetos.Values)
                {
                    listaTarjetasData.Add(new TarjetaData
                    {
                        Titular = tarjeta.Titular,
                        UsuarioOperario = tarjeta.UsuarioOperario,
                        NumeroTarjeta = tarjeta.NumeroTarjeta,
                        CodigoSeguridad = tarjeta.CodigoSeguridad,
                        FechaVencimiento = tarjeta.FechaVencimiento,
                        Saldo = tarjeta.Saldo
                    });
                }

                var serializador = new XmlSerializer(typeof(List<TarjetaData>));
                using (var writer = new StringWriter())
                {
                    serializador.Serialize(writer, listaTarjetasData);
                    return writer.ToString();
                }
            }

            // Cambios en la firma del método Deserializacion
            public Dictionary<long, TarjetaDebito> Deserializacion(string datos)
            {
                var serializador = new XmlSerializer(typeof(List<TarjetaData>));
                using (var reader = new StringReader(datos))
                {
                    var listaTarjetasData = (List<TarjetaData>)serializador.Deserialize(reader);
                    var diccionarioTarjetas = new Dictionary<long, TarjetaDebito>();

                    foreach (var tarjetaData in listaTarjetasData)
                    {
                        var tarjeta = new TarjetaDebito(
                            tarjetaData.Titular,
                            tarjetaData.UsuarioOperario,
                            tarjetaData.NumeroTarjeta,
                            tarjetaData.CodigoSeguridad,
                            tarjetaData.FechaVencimiento
                        );

                        tarjeta.Saldo = tarjetaData.Saldo;
                        diccionarioTarjetas.Add(tarjeta.NumeroTarjeta, tarjeta);
                    }

                    return diccionarioTarjetas;
                }
            }

            public void GuardarEnArchivo()
            {
                var diccionarioTarjetas = new Dictionary<long, TarjetaDebito> { { this.NumeroTarjeta, this } };
                string tarjetaXml = Serializacion(diccionarioTarjetas);
                File.AppendAllText(ArchivoTarjetas, tarjetaXml + Environment.NewLine);
            }


            public void GenerarInformePDF()
            {

            }

            public void VerificacionAdminTrial()
            {
            }

            //METODOS//

            public bool UsuarioTieneTarjetaRegistrada(string nombreUsuario)
            {
                // Leer el contenido del archivo XML
                string contenidoXml = File.ReadAllText(ArchivoTarjetas);

                // Deserializar el contenido del archivo XML a un diccionario de TarjetaDebito
                var diccionarioTarjetas = Deserializacion(contenidoXml);

                // Verificar si el nombre de usuario ya está registrado en el diccionario
                return diccionarioTarjetas.Values.Any(tarjeta => tarjeta.UsuarioOperario == nombreUsuario);
            }

        }
    }
}


