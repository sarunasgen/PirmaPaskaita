using PirmaUzduotis;
using System;
using System.Text;

namespace Kazkas
{
    public class KazkasProgram
    {
        
        public static void Main(string[] args)
        {
            
            List<Klientas> klientai = new List<Klientas>();
            //klientai.Add(SukurtiKlienta());
            //klientai.Add(SukurtiKlienta());
            //klientai.Add(SukurtiKlienta());

            VeiksmaiSuFailais veiksmai = new VeiksmaiSuFailais("ManoKlientuSarasas.csv");
            //veiksmai.IrasykKlientusIFaila(klientai);

            klientai = veiksmai.SkaitytiKlientuSarasa();

            foreach(Klientas k in klientai)
            {
                Console.WriteLine($"{k.AsmensKodas}  {k.Vardas}  {k.Pavarde}");
            }
            
            
        }
        public static Klientas SukurtiKlienta()
        {
            Console.WriteLine("Asm. Kodas: ");
            long asmKodas = long.Parse(Console.ReadLine());
            Console.WriteLine("Vardas: ");
            string vardas = (Console.ReadLine());
            Console.WriteLine("Pavarde: ");
            string pavarde = (Console.ReadLine());
            return new Klientas(asmKodas, vardas, pavarde);
        }
    }
}


