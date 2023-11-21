using static BibliotecaClases.Interfaces.InterfazSerializacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace BibliotecaClases.Usuarios_Tarjetas
{
    public class ClassTarjetaDebito
    {
        public class TarjetaDebito : ISerializacion<TarjetaDebito>
        {
            private const string ArchivoTarjetas = "TarjetasDataBase.xml";

            public TarjetaDebito(string nombredueño, long numerodetarjeta, int cvvdetarjeta, DateTime vencimientodetarjeta)

            {
                NombreOperario = nombredueño;
                NumeroTarjeta = numerodetarjeta;
                CodigoSeguridad = cvvdetarjeta;
                FechaVencimiento = vencimientodetarjeta;
                Titular = nombredueño;
                Saldo = 10000;
            }

            //ATRIBUTOS//
            public string NombreOperario { get; set; }
            public long NumeroTarjeta { get; set; }
            public int CodigoSeguridad { get; set; }
            public DateTime FechaVencimiento { get; set; }
            public string Titular { get; set; }
            public decimal Saldo { get; set; }

            //CONTRATO//
            public string Serializacion(TarjetaDebito objeto)
            {
                var serializador = new XmlSerializer(typeof(TarjetaDebito));
                using (var writer = new StringWriter())
                {
                    serializador.Serialize(writer, objeto);
                    return writer.ToString();
                }
            }

            public TarjetaDebito Deserializacion(string datos)
            {
                var serializador = new XmlSerializer(typeof(TarjetaDebito));
                using (var reader = new StringReader(datos))
                {
                    return (TarjetaDebito)serializador.Deserialize(reader);
                }
            }

            public void GuardarEnArchivo()
            {
                string tarjetaXml = Serializacion(this);
                File.AppendAllText(ArchivoTarjetas, tarjetaXml + Environment.NewLine);
            }

        }
    }
}


