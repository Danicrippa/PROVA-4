using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA_4
{
    public class Calciatore
    {
     public Calciatore() { }
        public int NumeroMaglia { get; set; }
        public string NomeCalciatore { get; set; }
        public DateTime DataNascita { get; set; }

        public Calciatore(int NumeroMaglia, string NomeCalciatore, DateTime DataNascita)
        {
            this.NumeroMaglia = NumeroMaglia;
            this.NomeCalciatore = NomeCalciatore;
            this.DataNascita = DataNascita;
        }

        public enum Categoria
        {
            Portiere,
            Difensore,
            Centrocampista,
            Attacante
        }

        
            }



}


//Tutti i giocatori sono in possesso dei seguenti attributi:  

//    • Numero di Maglia 
//    • Nome 
//    • Data di Nascita 
