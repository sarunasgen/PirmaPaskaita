using PagrindinisProgramosFunckionalumas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagrindinisProgramosFunckionalumas.Contracts
{
    public interface IAutomobilioParkoValdymas
    {
        void PasalintiAutomobili(TransportoPriemone automobilis);
        List<TransportoPriemone> RastiAutomobiliusPagalRakta(string raktas);
        void PridetiKlienta(Klientas klientas);
        void PridetiAutomobili(TransportoPriemone automobilis);
        void SaugotiBusena();
        void SpausdinkRandomTeksta() => Console.WriteLine("Random text");
        
    }
}
