using PagrindinisProgramosFunckionalumas.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagrindinisProgramosFunckionalumas.Models
{
    public class Motociklas : TransportoPriemone
    {
        public AutomobilioBukle Bukle { get; set; }
        public int Rida { get; set; }
    }
}
