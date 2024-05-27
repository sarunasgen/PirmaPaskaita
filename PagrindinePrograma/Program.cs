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
            int k = 12;

            for (int i = 0; i < k; i++)
            {
                Console.Write(i + " ");
            }
            
            


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