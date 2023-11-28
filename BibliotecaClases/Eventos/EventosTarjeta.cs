using BibliotecaClases.Usuarios_Tarjetas;

namespace BibliotecaClases.Eventos
{
    public class EventosTarjeta
    {
        public event EventHandler<ClassTarjetaDebito.TarjetaDebito> DatosCapturados;

        public ClassTarjetaDebito.TarjetaDebito CapturarDatosTarjeta(string nombredueño, string usuarioOperario, long numerodetarjeta, int cvvdetarjeta, DateTime vencimientodetarjeta)
        {

            ClassTarjetaDebito.TarjetaDebito nuevaTarjeta = new ClassTarjetaDebito.TarjetaDebito(nombredueño, usuarioOperario, numerodetarjeta, cvvdetarjeta,vencimientodetarjeta);
            OnDatosCapturados(nuevaTarjeta);
            return nuevaTarjeta;

        }

        protected virtual void OnDatosCapturados(ClassTarjetaDebito.TarjetaDebito tarjeta)
        {
            DatosCapturados?.Invoke(this, tarjeta);
        }


    }
}
