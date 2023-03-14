using System;
using System.Collections.Generic;
namespace LeListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t Le liste");
            /*
             * Le liste sono il contrario degli ArrayList
             * Gli ArreyList hanno le seguenti carratteristiche:
             * - Infiniti elementi
             * - Possiamo Rimuovere, Rimpiazzare ed Aggiungere
             * - Possiamo inserire qualsasi tipo di dato
             * 
             * Le liste hanno le seguenti carratteristiche:
             * - Sono infinite
             * - Possiamo Rimuovere ed Aggiungere
             * - Ma dobbiamo inserire tipi di dati coerenti
             * - Dobbiamo riportare using System.Collections.Generic;
                Generico solo per un tipo di dato
                Non generico diversi tipi di dati assieme
             */

            int[] arrayInteri = { 8, 9, 10 };
            string[] arrayStringhe = { "Ciao", "Come", "va" };
            List<int> prova = new List<int>() { 1, 2, 3, 4, 5, 6};

            //Aggiungere elementi
            prova.Add(7);//Aggiunge in coda
            prova.AddRange(arrayInteri); //Possiamo inserire delle Collection
            //prova.AddRange(arrayStringhe); Non possiamo visto che sono stringhe

            prova.Insert(0, 55);//Aggiungiamo il valore 55 all'indice 0 spostando di 1 gli elementi all'interno della lista
            prova.InsertRange(8, arrayInteri); //Aggingiamo dall'indice 8 in poi l'arrayinteri

            //Leggere le liste
            Console.WriteLine(prova[7]);
            prova[0] = 0;

            //Eliminare valori
            prova.Remove(0);//Rimuoviamo il valore 0
            prova.RemoveAt(10);//Rimuoviamo l'indice 10
            prova.RemoveRange(3, 4);//Rimuoviamo dall'indice 3 all'indice 4
            Console.WriteLine("prova contiene il valore 2? "+ prova.Contains(2));//Verifica che la lista contenga il valore 2
            prova.Clear();//Pulisce la lista cancellando tutti i valori
            prova.Add(1);
            prova.Add(2);
            prova.Add(3);
            prova.Add(4);

            //Stampare la lista
            foreach(int item in prova)
            {
                Console.WriteLine(item);
            }
            for(int i=0; i<prova.Count; i++)
            {
                Console.WriteLine("Il valore è: " + prova[i]);
            }
        }
    }
}