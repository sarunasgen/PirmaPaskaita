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
    public class MotocikluParkoValdymas : IAutomobilioParkoValdymas
    {
        private List<Motociklas> Motociklai = new List<Motociklas>();
        private List<Klientas> Klientai = new List<Klientas>();
        private readonly VeiksmaiSuFailais _veiksmaiSuFailais;

        public MotocikluParkoValdymas()
        {
            _veiksmaiSuFailais = new VeiksmaiSuFailais();
        }
        public void SaugotiBusena()
        {
            _veiksmaiSuFailais.SpausdintiMotociklusIFaila(Motociklai);
            _veiksmaiSuFailais.SpausdintiKlientusIFaila(Klientai);
        }
        public void PridetiKlienta(Klientas klientas)
        {
            Klientai.Add(klientas);
        }
        public void PridetiAutomobili(TransportoPriemone automobilis)
        {
            Motociklai.Add((Motociklas)automobilis);
        }

        public void PasalintiAutomobili(TransportoPriemone automobilis)
        {
            Motociklai.Remove((Motociklas)automobilis);
        }

        public List<TransportoPriemone> RastiAutomobiliusPagalRakta(string raktas)
        {
            List<TransportoPriemone> rastiAutomobiliai = new List<TransportoPriemone>();
            foreach (Motociklas motociklas in Motociklai)
            {
                if (motociklas.Marke.Contains(raktas) || motociklas.Modelis.Contains(raktas))
                {
                    rastiAutomobiliai.Add(motociklas);
                }
            }
            return rastiAutomobiliai; 
        }
        public void SpausdinkRandomTeksta()
        {
            Console.WriteLine("Labai random tekstas");
        }



    }
}
