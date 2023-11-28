using OoplesFinance.YahooFinanceAPI.Enums;
using OoplesFinance.YahooFinanceAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Nuggets
{
    internal class FinanceNugget
    {
        public class Accion
        {
            public string NombreAccion { get; set; }
            public decimal PrecioAlta { get; set; }
            public decimal PrecioBaja { get; set; }
            public int Cantidad { get; set; }
        }


        public static DateTime startDate = DateTime.Now.AddYears(-1);
        public static string symbol = "AAPL";
        public static string fundSymbol = "VSMPX";
        public static string[] simbolos = new string[] { symbol, "MSFT", "NFLX", "TSLA", "YHOO", "SPY", "A", "AA", "GOOG", "F", "UBER", "LYFT" };
        public static YahooClient yahooClient = new YahooClient();

        public static async Task<IEnumerable<OoplesFinance.YahooFinanceAPI.Models.HistoricalData>> TestingNugget()
        {
            return await yahooClient.GetHistoricalDataAsync(symbol, DataFrequency.Daily, startDate);
        }
    }
}
