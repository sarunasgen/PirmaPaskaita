using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PagrindinePrograma.Program;

namespace PagrindinePrograma
{
    public class FunkcijuMainKlase
    {
        public TekstoSpausdinimas x;
        public delegate void RaidesSpausdinimas();
        public RaidesSpausdinimas y;
        public FunkcijuMainKlase(TekstoSpausdinimas spausdinimoFunkcija)
        {
            x = spausdinimoFunkcija;
        }
        public void SpausdinkTeksta(string manoRandomText)
        {
            x.Invoke(manoRandomText);
        }
        public void SpausdinkA()
        {
            Console.WriteLine("A");
        }
        public void SpausdinkB()
        {
            Console.WriteLine("B");
        }
        public void SpausdinkC()
        {
            Console.WriteLine("C");
        }
        public void PriskirkA()
        {
            y = new RaidesSpausdinimas(SpausdinkA);
        }
        public void PriskirkB()
        {
            y = new RaidesSpausdinimas(SpausdinkB);
        }
        public void PriskirkC()
        {
            y = new RaidesSpausdinimas(SpausdinkC);
        }
        public RaidesSpausdinimas raidesSpausdinimas()
        {
            return y;
        }
    }
}
