using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Interfaces
{
    public class InterfazSerializacion
    {
        public interface ISerializacionJson
        {
            string SerializacionDeJson();
            void DeserializacionDelJson(string nombreJson);
        }
    }
}
