using BibliotecaClases.Usuarios_Tarjetas;

namespace BibliotecaClases.Eventos
{
    internal class EventosTarjeta
    {
        public event EventHandler<ClassTarjetaDebito.TarjetaDebito> DatosCapturados;

        public ClassTarjetaDebito.TarjetaDebito CapturarDatosUsuario(string nombredueño, long numerodetarjeta, int cvvdetarjeta, DateTime vencimientodetarjeta)
        {

            ClassTarjetaDebito.TarjetaDebito nuevaTarjeta = new ClassTarjetaDebito.TarjetaDebito(nombredueño, numerodetarjeta, cvvdetarjeta,vencimientodetarjeta);
            OnDatosCapturados(nuevaTarjeta);
            return nuevaTarjeta;

        }

        protected virtual void OnDatosCapturados(ClassTarjetaDebito.TarjetaDebito tarjeta)
        {
            DatosCapturados?.Invoke(this, tarjeta);
        }

        //public void EventosTarjeta(object sender, ClassTarjetaDebito.TarjetaDebito tarjeta)
        //{
        //    List<ClassUsuarios.User> listaUsuarios = new List<ClassUsuarios.User> { tarjeta };

        //    string tarjetalista = tarjeta.Serializacion(listatarjeta);
        //    tarjeta.GuardarEnArchivo();
        //}

    }
}
