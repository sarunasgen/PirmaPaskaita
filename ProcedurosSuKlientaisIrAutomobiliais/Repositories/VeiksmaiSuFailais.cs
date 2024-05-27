using PagrindinisProgramosFunckionalumas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedurosSuKlientaisIrAutomobiliais.Repositories
{
    internal class VeiksmaiSuFailais
    {
        public void SpausdintiAutomobiliusIFaila(List<Automobilis> automobiliai)
        {
            using(StreamWriter sw = new StreamWriter("auto.txt"))
            {
                sw.WriteLine("Automobilių sarasas");
                foreach(TransportoPriemone automobilis in automobiliai)
                {
                    sw.WriteLine($"{automobilis.Marke}  {automobilis.Modelis}  {automobilis.PirmosRegistracijosData.ToShortDateString()}  {automobilis.VINKodas}");
                }
            }
        }
        public void SpausdintiMotociklusIFaila(List<Motociklas> automobiliai)
        {
            using (StreamWriter sw = new StreamWriter("auto.txt"))
            {
                sw.WriteLine("Automobilių sarasas");
                foreach (TransportoPriemone automobilis in automobiliai)
                {
                    sw.WriteLine($"{automobilis.Marke}  {automobilis.Modelis}  {automobilis.PirmosRegistracijosData.ToShortDateString()}  {automobilis.VINKodas}");
                }
            }
        }
        public void SpausdintiKlientusIFaila(List<Klientas> klientai)
        {
            using (StreamWriter sw = new StreamWriter("klientai.txt"))
            {
                sw.WriteLine("Automobilių sarasas");
                foreach (Klientas klientas in klientai)
                {
                    sw.WriteLine($"{klientas.Vardas}  {klientas.Pavarde} {(int)klientas.Statusas}");
                }
            }
        }
    }
}
