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
            string Serializacion(List<T> objetos);
            T Deserializacion(string datos);
            void GuardarEnArchivo();
            public void GenerarInformePDF();
            public void VerificacionAdminTrial();
        }


    }
}
