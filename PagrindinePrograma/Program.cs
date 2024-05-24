using PagrindinisProgramosFunckionalumas.Enums;
using PagrindinisProgramosFunckionalumas.Models;
using ProcedurosSuKlientaisIrAutomobiliais.Services;
using PagrindinisProgramosFunckionalumas.Contracts;
using System;
using static PagrindinePrograma.FunkcijuMainKlase;

namespace PagrindinePrograma
{
    public class Program
    {
        public delegate void TekstoSpausdinimas(string tekstas);
        public static void Main(string[] args)
        {
            Automobilis skoda = new Automobilis("Skoda", "Octavia", DateTime.Now, "WAUZZZ4353483274234", AutomobilioBukle.Naujas);
            Automobilis skoda2 = new Automobilis("Skoda", "Octavia", DateTime.Now, "WAUZZZ4353483274234", AutomobilioBukle.PaskutineKelione);
            Automobilis skoda3 = new Automobilis("Skoda", "Octavia", DateTime.Now, "WAUZZZ4353483274234", AutomobilioBukle.Naujas);
            Automobilis skoda4 = new Automobilis("Skoda", "Octavia", DateTime.Now, "WAUZZZ4353483274234", AutomobilioBukle.Naujas);
            Automobilis skoda5 = new Automobilis("Skoda", "Octavia", DateTime.Now, "WAUZZZ4353483274234", AutomobilioBukle.Naujas);

            Motociklas moto1 = new Motociklas
            {
                Marke = "Yamaha"
            };
            Motociklas moto2 = new Motociklas();

            Klientas jonas = new Klientas("Jonas", "Jonaitis", KlientoStatusas.NaujasKlientas);
            Klientas jonas1 = new Klientas("Jonas", "Jonaitis", KlientoStatusas.VIPKlientas);
            Klientas jonas2 = new Klientas("Jonas", "Jonaitis", KlientoStatusas.StandartinisKlientas);
            Klientas jonas3 = new Klientas("Jonas", "Jonaitis", KlientoStatusas.NaujasKlientas);

            IAutomobilioParkoValdymas AutoParkas = new AutomobiliuParkoValdymas();
            IAutomobilioParkoValdymas MotoParkas = new MotocikluParkoValdymas();

            AutoParkas.PridetiKlienta(jonas);
            AutoParkas.PridetiKlienta(jonas1);
            AutoParkas.PridetiKlienta(jonas2);
            AutoParkas.PridetiKlienta(jonas3);

            AutoParkas.PridetiAutomobili(skoda);
            AutoParkas.PridetiAutomobili(skoda2);
            AutoParkas.PridetiAutomobili(skoda3);
            AutoParkas.PridetiAutomobili(skoda4);
            AutoParkas.PridetiAutomobili(skoda5);

            AutoParkas.PasalintiAutomobili(skoda3);
            MotoParkas.PridetiAutomobili(moto1);
            AutoParkas.SaugotiBusena();
            AtliktiMokejimaUzTPNuoma(AutoParkas);
            AtliktiMokejimaUzTPNuoma(MotoParkas);

            RastiTrasnportoPriemoneParke(AutoParkas, "Skoda");
            RastiTrasnportoPriemoneParke(MotoParkas, "Yamaha");

            TekstoSpausdinimas tekstoSpausdinimoDelegatas = new TekstoSpausdinimas(TekstoSpausdinimasA);
            string textToPrint = "Mano ";
            if(textToPrint.Length > 10 )
            {
                tekstoSpausdinimoDelegatas = new TekstoSpausdinimas(TekstoSpausdinimasB);
            }
            FunkcijuMainKlase mainKlase = new FunkcijuMainKlase(tekstoSpausdinimoDelegatas);
            mainKlase.SpausdinkTeksta(textToPrint);

            mainKlase.PriskirkB();

            RaidesSpausdinimas spausdinimas = mainKlase.raidesSpausdinimas();

            spausdinimas.Invoke();



        }
        private static void AtliktiMokejimaUzTPNuoma(IAutomobilioParkoValdymas valdymas)
        {

        }
        private static void RastiTrasnportoPriemoneParke(IAutomobilioParkoValdymas valdymas, string raktas)
        {
            List<TransportoPriemone> tp = valdymas.RastiAutomobiliusPagalRakta(raktas);
            tp.First().Sugadinti();
            valdymas.SpausdinkRandomTeksta();
        }
        private static void TekstoSpausdinimasA(string tekstas)
        {
            Console.WriteLine(tekstas + "is funkcijos A");
        }
        private static void TekstoSpausdinimasB(string tekstas)
        {
            Console.WriteLine(tekstas + "is funkcijos B");
        }
    }
}