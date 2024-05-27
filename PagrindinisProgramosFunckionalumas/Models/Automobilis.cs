using PagrindinisProgramosFunckionalumas.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagrindinisProgramosFunckionalumas.Models
{
    public class Automobilis : TransportoPriemone
    {
        public AutomobilioBukle Bukle { get; set; }
        public Automobilis(string marke, string modelis, DateTime regdata, string vinkodas, AutomobilioBukle bukle) 
            : base(marke,modelis,regdata,vinkodas)
        {
            Bukle = bukle;
        }
        public override void Sugadinti()
        {
            Bukle = AutomobilioBukle.PaskutineKelione;
            Sugedes = true;
        }
    }
}
