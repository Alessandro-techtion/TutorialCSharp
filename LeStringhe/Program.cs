using System;
//https://codegrind.it/csharp/lavorare-con-le-stringhe-lezione-06/
namespace LeStringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t Le STRINGHE");

            // escape caratteri, concat, format, interp,
            // metodi: toUpper, toLower, Length, indexing, IndexOf, Substring

            //escape caratteri
            string stringa = "\ncitazione : \"si vive una volta sola\" ";
            Console.WriteLine(stringa);

            //concatenazione
            string nome = "Luca";
            string cognome = "Rossi";
            string unione = "\nCiao sono " + nome + " " + cognome;
            Console.WriteLine(unione);

            //formattazzione
            Console.WriteLine("\nBuongiorno sono {0} {1}", nome,cognome);
            /*
             * Questo tipo di formattazione possiamo farla solo nella funzione
             * Perciò se facciamo così
             * string unione = "\nBuongiorno sono {0} {1}", nome,cognome);
             * darà errore!!!
             * Ma:
             * Usando il metodo Format possiamo
             */
            unione = string.Format("\nBuongiorno sono {0} {1}", nome, cognome);
            Console.WriteLine(unione);

            //Interpolazione
            unione = "bhgyfgghgg";
            Console.WriteLine($"\nBuongiorno sono {nome} {cognome}");
            unione = $"\nBuongiorno sono {nome} {cognome}";
            /*
             * Se {0} {1} ci crea confusione possiamo inserire direttamente i nomi
             * delle variabili basta inserire '$' all'inizio
             */

            
            //Metodo ToUpper and ToLower
            nome = "Alessandro";
            string nomeMaiuscolo = nome.ToUpper();
            Console.WriteLine("\n Metodo ToUpper " + nomeMaiuscolo);
            string nomeMinuscolo = nome.ToLower();
            Console.WriteLine("\n Metodo ToLower " + nomeMinuscolo);

            //Metodo Length
            int lunghezzaNome = nome.Length;
            Console.WriteLine("\n Metodo Length : " + lunghezzaNome);

            //Metodo Indexing
            char carattere = nome[1];
            Console.WriteLine("\n Metodo Indexing " + carattere);
            /*
             * Il metodo indexing stampa il carattere alla posizione 1 
             * 0 1 2 3 4 5 6 7 8 9
             * a l e s s a n d r o
             */

            //Metodo IndexOf
            int posizioneCarattere = nome.IndexOf("r");
            Console.WriteLine("\n Metodo IndexOf " + posizioneCarattere);

            //Metodo SubString
            cognome = "Rossignoli";
            string subString = cognome.Substring(5);
            Console.WriteLine("\n Metodo Substring " + subString);

            subString = cognome.Substring(cognome.Length -3);
            Console.WriteLine("\n Metodo Substring 2 " + subString);
            /*
             * Stamperà la stringa lasciando fuori Rossi
             */
        }
    }
}