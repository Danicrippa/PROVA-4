using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA_4
{
    public class Squadra
    {
        public string Nome { get; set; }
        public DateTime dataFondazione { get; set; }
        public string Campionato { get; set; }
        public string NomePresidente { get; set; }
        public string NomeAllenatore { get; set; }


        public Squadra(string Nome, DateTime dataFondazione, string Campionato, string NomePresidente, string NomeAllenatore)
        {
            this.Nome = Nome;
            this.dataFondazione = dataFondazione;
            this.Campionato = Campionato;
            this.NomePresidente = NomePresidente;
            this.NomeAllenatore = NomeAllenatore;

        }
    }
}
//Esercitazione pratica 
//Realizzare una Console Application per gestire una squadra di calcio. 
 
//La squadra è caratterizzata dai seguenti attributi: 
 
//    • Nome 
//    • Data di Fondazione 
//    • Campionato disputato 
//    • Nome del Presidente 
//    • Nome dell’Allenatore 
//    • Rosa (elenco di Calciatori) 
 


