using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Interfaces
{
    public class InterfazSerializacion
    {
        public interface ISerializacion<T>
        {
            string Serializacion(T objeto);
            T Deserializacion(string datos);
            void GuardarEnArchivo();
        }
    }
}
