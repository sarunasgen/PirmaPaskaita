using PagrindinisProgramosFunckionalumas.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagrindinisProgramosFunckionalumas.Models
{
    public class Klientas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        private Automobilis NuomojamasAutomobilis { get; set; }
        public KlientoStatusas Statusas { get; set; }

        public Klientas(string vardas, string pavarde, KlientoStatusas statusas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Statusas = statusas;
        }
        public Klientas(string vardas, string pavarde, Automobilis nuomojamasAutomobilis, KlientoStatusas statusas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            NuomojamasAutomobilis = nuomojamasAutomobilis;
            Statusas = statusas;
        }
    }
}
