using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA_4
{
    public class Elenco
    {


        //Ciascun Calciatore in Rosa appartiene ad una categoria: Portiere, Difensore, Centrocampista, Attaccante.
        public enum Categoria
        {
            Portiere,
            Difensore,
            Centrocampista,
            Attacante
        }

    }

}

//    • Per i  Portieri vanno registrati il Numero di Gol Subiti e il Numero di Rigori Parati 
//    • Per i Difensori vanno registrati il Numero di Tackle Riusciti 
//    • Per i Centrocampisti vanno registrati il Numero di Passaggi Tentati e il Numero di Passaggi Riusciti 
//    • Per gli Attaccanti vanno registrati il Numero di Gol Realizzati 