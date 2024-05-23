using PagrindinisProgramosFunckionalumas.Enums;
using PagrindinisProgramosFunckionalumas.Models;
using ProcedurosSuKlientaisIrAutomobiliais.Services;
using System;

namespace PagrindinePrograma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Automobilis skoda = new Automobilis("Skoda", "Octavia", DateTime.Now, "WAUZZZ4353483274234", AutomobilioBukle.Naujas);
            Automobilis skoda2 = new Automobilis("Skoda", "Octavia", DateTime.Now, "WAUZZZ4353483274234", AutomobilioBukle.PaskutineKelione);
            Automobilis skoda3 = new Automobilis("Skoda", "Octavia", DateTime.Now, "WAUZZZ4353483274234", AutomobilioBukle.Naujas);
            Automobilis skoda4 = new Automobilis("Skoda", "Octavia", DateTime.Now, "WAUZZZ4353483274234", AutomobilioBukle.Naujas);
            Automobilis skoda5 = new Automobilis("Skoda", "Octavia", DateTime.Now, "WAUZZZ4353483274234", AutomobilioBukle.Naujas);
            Klientas jonas = new Klientas("Jonas", "Jonaitis", KlientoStatusas.NaujasKlientas);
            Klientas jonas1 = new Klientas("Jonas", "Jonaitis", KlientoStatusas.VIPKlientas);
            Klientas jonas2 = new Klientas("Jonas", "Jonaitis", KlientoStatusas.StandartinisKlientas);
            Klientas jonas3 = new Klientas("Jonas", "Jonaitis", KlientoStatusas.NaujasKlientas);

            AutomobiliuParkoValdymas AutoParkas = new AutomobiliuParkoValdymas();

            AutoParkas.PridetiKlienta(jonas);
            AutoParkas.PridetiKlienta(jonas1);
            AutoParkas.PridetiKlienta(jonas2);
            AutoParkas.PridetiKlienta(jonas3);

            AutoParkas.PridetiAutomobili(skoda);
            AutoParkas.PridetiAutomobili(skoda2);
            AutoParkas.PridetiAutomobili(skoda3);
            AutoParkas.PridetiAutomobili(skoda4);
            AutoParkas.PridetiAutomobili(skoda5);

            AutoParkas.SaugotiBusena();

        }
    }
}