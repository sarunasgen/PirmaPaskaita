using PagrindinisProgramosFunckionalumas.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagrindinisProgramosFunckionalumas.Models
{
    public class Automobilis
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public DateTime PirmosRegistracijosData { get; set; }
        public string VINKodas { get; set; }
        public AutomobilioBukle Bukle { get; set; }
        public Automobilis(string marke, string modelis, DateTime regdata, string vinkodas, AutomobilioBukle bukle)
        {
            Marke = marke;
            Modelis = modelis;
            PirmosRegistracijosData = regdata;
            VINKodas = vinkodas;
            Bukle = bukle;
        }
    }
}
