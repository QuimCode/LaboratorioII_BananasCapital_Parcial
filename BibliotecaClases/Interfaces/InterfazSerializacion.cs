using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaClases.Usuarios_Tarjetas.ClassTarjetaDebito;

namespace BibliotecaClases.Interfaces
{
    public class InterfazSerializacion
    {
        public interface ISerializacion<T>
        {
            string Serializacion(List<T> objetos);
            T Deserializacion(string datos);
            void GuardarEnArchivo();
            void VerificacionAdminTrial();
        }

        public interface ITarjetaDebitoSerializacion
        {
            string Serializacion(Dictionary<long, TarjetaDebito> objetos);
            Dictionary<long, TarjetaDebito> Deserializacion(string datos);
            void GuardarEnArchivo();
            void VerificacionAdminTrial();
        }
    }
}

