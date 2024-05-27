using PagrindinisProgramosFunckionalumas.Contracts;
using PagrindinisProgramosFunckionalumas.Models;
using ProcedurosSuKlientaisIrAutomobiliais.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedurosSuKlientaisIrAutomobiliais.Services
{
    public class AutomobiliuParkoValdymas : IAutomobilioParkoValdymas
    {
        private List<Automobilis> Automobiliai = new List<Automobilis>();
        private List<Klientas> Klientai = new List<Klientas>();
        private readonly VeiksmaiSuFailais _veiksmaiSuFailais;

        public AutomobiliuParkoValdymas()
        {
            _veiksmaiSuFailais = new VeiksmaiSuFailais();
        }
        public void SaugotiBusena()
        {
            _veiksmaiSuFailais.SpausdintiAutomobiliusIFaila(Automobiliai);
            _veiksmaiSuFailais.SpausdintiKlientusIFaila(Klientai);
        }
        public void PridetiKlienta(Klientas klientas)
        {
            Klientai.Add(klientas);
        }

        public List<TransportoPriemone> RastiAutomobiliusPagalRakta(string raktas)
        {
            List<TransportoPriemone> rastiAutomobiliai = new List<TransportoPriemone>();
            foreach(Automobilis automobilis in Automobiliai)
            {
                if(automobilis.Marke.Contains(raktas) || automobilis.Modelis.Contains(raktas))
                {
                    rastiAutomobiliai.Add(automobilis) ;
                }
            }
            return rastiAutomobiliai;
        }

        public void PasalintiAutomobili(TransportoPriemone automobilis)
        {
            Automobiliai.Remove((Automobilis)automobilis);
        }

        public void PridetiAutomobili(TransportoPriemone automobilis)
        {
            Automobiliai.Add((Automobilis)automobilis);
            TaisytiVisusAutomobilius();
        }
        private void TaisytiVisusAutomobilius()
        {
            foreach(Automobilis automobilis in Automobiliai)
            {
                automobilis.Taisyti();
            }
        }
    }
}
