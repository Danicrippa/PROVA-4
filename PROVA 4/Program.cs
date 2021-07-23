using System;
using System.IO;


namespace PROVA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto al Giocco");

            bool continuare = true;
            do
            {
                Console.WriteLine("Premi 1 per aggiungere giocatore all'elenco");
                Console.WriteLine("Premi 2 per vendere giocatore");
                Console.WriteLine("Premi 3 per identificare gli giocatori titolari");
                Console.WriteLine("Premi 4 per stampare statistiche di tutta la squadra titolare");
                Console.WriteLine("Premi 5 per uscire");
                bool isint = true;
                int scelta = 0;
                do
                {
                    isint = int.TryParse(Console.ReadLine(), out scelta);
                } while (!isint);

                switch (scelta)
                {
                    case 1:
                        Menu.AggiungeCalciatore();
                        break;
                    case 2:
                        Menu.VendereCalciatore();
                        break;
                    case 3:
                        Menu.IdentificaCalciatore();
                        break;
                    case 4:
                        Menu.StampaStatische();
                        break;
                    case 5:
                        continuare = false;
                        break;
                }
            } while (continuare);

            List<Calciatore> calciatori = new List<Calciatore>(11);

            Calciatore.Add(new Calciatore(5, "Mario", 1993 / 06 / 01);
            Calciatore.Add(new Calciatore(6, "Pietro", 1999 / 05 / 02));
            Calciatore.Add(new Calciatore(4, "Giovanni", 2000 / 01 / 07));

            foreach (Calciatore c in calciatori)
            {
                Console.WriteLine(c.NomeCalciatore + "" + c.DataNascita + "" + c.NumeroMaglia);
            }
        }
    }


}

//L’applicazione deve permettere di: 
//    • Aggiungere Giocatori alla Rosa (elenco)
//    • Vendere Giocatori (rimuoverli dalla Rosa) 
//    • Gestire la squadra titolare (ovvero identificare gli 11 giocatori titolari) con lo schema 4-4-2 (4 Difensori, 4 Centrocampisti, 2 Attaccanti) 
//    • Stampare le statistiche di tutta la squadra titolare 

