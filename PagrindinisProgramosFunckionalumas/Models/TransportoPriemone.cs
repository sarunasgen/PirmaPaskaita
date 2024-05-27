using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagrindinisProgramosFunckionalumas.Models
{
    public class TransportoPriemone
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public DateTime PirmosRegistracijosData { get; set; }
        public string VINKodas { get; set; }

        public bool Sugedes { get; set; } = false;

        public TransportoPriemone(string marke, string modelis, DateTime prd, string vinkodas)
        { 
            Marke = marke;
            Modelis = modelis;
            PirmosRegistracijosData = prd;
            VINKodas = vinkodas;

        }

        public void Taisyti()
        {
            Sugedes = false;
        }
        public virtual void Sugadinti()
        {
            Sugedes = true;
        }
    }
}
