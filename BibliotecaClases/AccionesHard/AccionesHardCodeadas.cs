using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaClases.Nuggets.FinanceNugget;

namespace BibliotecaClases.AccionesHard
{
    public class AccionesHardCodeadas
    {
        public static void CrearAccionesHard()
        {
            Dictionary<string, Accion> acciones = new Dictionary<string, Accion>();

            acciones.Add("AAPL", new Accion
            {
                NombreAccion = "AAPL",
                PrecioAlta = 138.40m,
                PrecioBaja = 2.38m, // Corregido: quitar el 0 al inicio
                Cantidad = 132
            });

            acciones.Add("GOOGL", new Accion
            {
                NombreAccion = "GOOGL",
                PrecioAlta = 2568.99m,
                PrecioBaja = 2510.50m,
                Cantidad = 250
            });

            acciones.Add("MSFT", new Accion
            {
                NombreAccion = "MSFT",
                PrecioAlta = 305.45m,
                PrecioBaja = 299.87m,
                Cantidad = 180
            });

            acciones.Add("TSLA", new Accion
            {
                NombreAccion = "TSLA",
                PrecioAlta = 780.25m,
                PrecioBaja = 760.50m,
                Cantidad = 150
            });

            acciones.Add("AMZN", new Accion
            {
                NombreAccion = "AMZN",
                PrecioAlta = 3450.75m,
                PrecioBaja = 3425.00m,
                Cantidad = 300
            });

            acciones.Add("NFLX", new Accion
            {
                NombreAccion = "NFLX",
                PrecioAlta = 590.60m,
                PrecioBaja = 580.25m,
                Cantidad = 120
            });

            acciones.Add("FB", new Accion
            {
                NombreAccion = "FB",
                PrecioAlta = 340.85m,
                PrecioBaja = 336.40m,
                Cantidad = 220
            });

            acciones.Add("GOOG", new Accion
            {
                NombreAccion = "GOOG",
                PrecioAlta = 2720.15m,
                PrecioBaja = 2685.50m,
                Cantidad = 280
            });

            acciones.Add("NVDA", new Accion
            {
                NombreAccion = "NVDA",
                PrecioAlta = 250.75m,
                PrecioBaja = 245.90m,
                Cantidad = 160
            });

            acciones.Add("AAP", new Accion
            {
                NombreAccion = "AAP",
                PrecioAlta = 185.30m,
                PrecioBaja = 182.15m,
                Cantidad = 180
            });

            acciones.Add("GM", new Accion
            {
                NombreAccion = "GM",
                PrecioAlta = 60.75m,
                PrecioBaja = 58.90m,
                Cantidad = 220
            });

            acciones.Add("CSCO", new Accion
            {
                NombreAccion = "CSCO",
                PrecioAlta = 45.25m,
                PrecioBaja = 44.10m,
                Cantidad = 150
            });

            acciones.Add("IBM", new Accion
            {
                NombreAccion = "IBM",
                PrecioAlta = 120.45m,
                PrecioBaja = 119.20m,
                Cantidad = 100
            });

            acciones.Add("ORCL", new Accion
            {
                NombreAccion = "ORCL",
                PrecioAlta = 80.60m,
                PrecioBaja = 79.35m,
                Cantidad = 130
            });

            acciones.Add("INTC", new Accion
            {
                NombreAccion = "INTC",
                PrecioAlta = 55.75m,
                PrecioBaja = 54.60m,
                Cantidad = 190
            });

            //Controlador guardarAcciones = new Controlador();
            //guardarAcciones.Guardar(acciones);
        }

        public static bool ArchivoExiste(string rutaArchivo)
        {
            return File.Exists(rutaArchivo);
        }

    }
}

