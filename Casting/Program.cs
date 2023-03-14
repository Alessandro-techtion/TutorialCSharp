using System;
//https://codegrind.it/csharp/casting-implicito-ed-esplicito-in-c-lezione-05/
namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t Casting   ");

            //Casting - Conversione
            //-Implicito, esplicito, funzioni di conversione
            
            int prova = 345;
            long qwerty = prova;
            Console.WriteLine("Casting Implicito " + qwerty);
            /*
             * Essendo 345 piccolo, possiamo inserirlo in una variabile più grande
             * Sarebbe come inserire una scatola in una scatola più grande
             *
             * long qwerty2 = 345;
             * int prova2 = qwerty2;
             *
             * Non possiamo fare il contrario
             */

            double prova3 = 34.23;
            int qwerty3 = (int)prova3; 
            /*
             * Abbiamo convertito in maniera esplicita un double in un int
             * Facendolo però abbiamo perso dei dati ovvero i valori dopo la virgola
             */
            Console.WriteLine("\n Casting Esplicito " + qwerty3);

            /*
             *string stringa = "55";
             *int numero = (int)stringa;
             * Noi possiamo anche inserire una scatola più grande in una più piccola, seppur tagliando qualcosa
             * Ma non potremmo mai inserire un elefante in una scatola
             * Per tanto non possiamo fare un casting di una stringa a un intero essendo i due totalmente diversi
             * 
             * O almeno non senza delle funzioni
            */

            int numero = 34;
            double doppio = 34.56;
            bool qwerty4 = true;

            string stringa = Convert.ToString(numero);
            string stringa2 = Convert.ToString(doppio);
            string stringa3 = Convert.ToString(qwerty4);
            Console.WriteLine("\n Casting tramite funzioni " + stringa);
            Console.WriteLine("\n Casting tramite funzioni " + stringa2);
            Console.WriteLine("\n Casting tramite funzioni " + stringa3);

            /*
             * Abbiamo convertito delle variabili numeriche in delle stringhe
             * 
             * Volendo possiamo fare anche ciò che non ci era permesso prima
             * double -> int
             */

            Console.WriteLine("\n Da double a int " + Convert.ToInt32(doppio));
        }
    }
}