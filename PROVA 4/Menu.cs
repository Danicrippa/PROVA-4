using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA_4
{
    public class Menu
    {
        public static void AggiungeCalciatore(List<Calciatore> calciatori)
        {
            if (calciatori.Count > 0)
            {
                int count = 1;
                foreach (Calciatore calciatore in calciatori)
                {
                    Console.WriteLine($"{count} - Nome: {Calciatore.NomeCalciatore} - DataNascita: {Calciatore.DataNascita}; 
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Giocatore non localizato, insira altro nome");
            }

            public static void VendereCalciatore(List<Calciatore> calciatori)
            {
                if (calciatori.Count > 0)
                {
                    int count = 1;
                    foreach (Calciatore calciatore in calciatori)
                    {
                        Console.WriteLine($"{count} - Nome: {Calciatore.(NomeCalciatore)} - DataNascita: {Calciatore.(DataNascita)}; 



                          count++;
                    }
                }
                else
                {
                    Console.WriteLine("Giocatore non localizato, insira altro nome");
                }
            }
            public static void IdentificaCalciatore(List<Calciatore> calciatori)

            {
                int count = 1;
                foreach (Calciatore calciatore in calciatori)
                {
                    Console.WriteLine($"{count} - Nome: {Calciatore.(NomeCalciatore)} - DataNascita: {Calciatore.(DataNascita)}; 
                    count++;
                }    else
                {
                    Console.WriteLine("Giocatore non localizato, insira altro nome");
                }
                public static void StampaStatische();
                {

                }

            }
        }

