using PagrindinisProgramosFunckionalumas.Models;
using ProcedurosSuKlientaisIrAutomobiliais.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedurosSuKlientaisIrAutomobiliais.Services
{
    public class AutomobiliuParkoValdymas
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
        public void PridetiAutomobili(Automobilis automobilis)
        {
            Automobiliai.Add(automobilis);
        }
        
    }
}
