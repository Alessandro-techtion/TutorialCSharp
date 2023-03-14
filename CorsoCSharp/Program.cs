using System; //Dire a C# che vogliamo utilizzare il namespace System

namespace CorsoCSharp //Package o cartella
{
    class Program //Una classe, essendo C# è un programma orientato agli oggetti
    {
        static void Main(String[] args) //Metodo main, entry point del nostro programma
        {
            Console.WriteLine("Hello World"); //Console fa parte della classe System

            System.Console.WriteLine("Hello World"); //Possiamo scriverlo anche così

            //System = namespace
            //Console = classe
            //WriteLine = funzione/metodo

            //Abbiamo delle funzioni che si trovano dentro delle classi che sono contenute nei namespace

            Console.Read(); // Andiamo a prendere il metodo Read della classe Console
                            // Serve per leggere un imput da tastiera

            //VARIABILI

            string nome = "Luca"; //Conterrà una stringa

            //Dichiarare una variabile:
            string cognome;
            //Assegnare una variabile:
            cognome = "Rossi";
            //Inizializzare una variabile
            int anni = 25;

            Console.Write("Ciao, io sono " + nome);
            Console.Write(" " + cognome);
            Console.Write(" e ho " + anni + " anni");

            /*
             * Possiamo creare anche delle variabili costanti
             * a cui non potremo cambiare il valore 
             */
            const float PI_GRECO = 3.14f; 

            char carattere = 'A'; //Il tipo char conterrà un carattere unico
            int numeroIntero = 2000000000;
            long numeroLungo = 2000000000000000000;
            float numeroFloat = 6.9f; //6 numeri , 9 decimali f alla fine
            double numeroDouble = 15.17; //15 numeri , 17 decimali
            decimal numeroDecimal = 28.29m; //28 numeri , 29 decimali m alla fine
            bool sino = true; //true o false 


            
        }
    }
}