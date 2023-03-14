using System;
using System.Collections;
using System.Collections.Generic;
namespace LeHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t Le HashTable");
            /*
             * Le HashTable sono delle Collections
             * Un isieme di più elementi che contengono
             * i valori chiave valore (keyvalue)
             * Key : value
             * La chiave ci serve per pescare il valore che ci interessa
             * Negli array e nelle liste utilizziamo gli indici per cercare i valori
             * Nelle HashTable cerchiamo tramite la key
             * Hashtable["chiave"] = valore
             */

            Hashtable prova = new Hashtable(); //Creare una Hashtable
            Hashtable prova2 = new Hashtable()
            {//Non possiamo avere 2 chiavi uguali, ma possiamo avere più valori uguali
                {"Lombardia","Milano" },
                {"Piemonte","Torino" },
                {"Liguria","Genova" },
                {"Lazio","Roma" },
                { 1, true }
            };
            prova2.Add("Veneto", "Venezia");
            prova2.Remove(4);

            prova.Add(1, "Antonio");
            prova.Add(2, "Davide");
            prova.Add(3, "Edoardo");

            //Stampare singolo
            Console.WriteLine(prova2["Lombardia"]);//Non lavoriamo per indice ma per chiave
            //Modificare
            prova2["Lombardia"] = "Mantova";
            Console.WriteLine();
            //NO stampare tutto
            foreach(DictionaryEntry città in prova2) //Dictionary sarà il tipo 
            {
                Console.WriteLine($"Chiave: {città.Key} --> Value: {città.Value}");

            }
            Console.WriteLine(prova2.ContainsKey("Lombardia"));
            Console.WriteLine(prova2.ContainsKey("Molise"));
            Console.WriteLine(prova2.ContainsValue("Genova"));

        }
    }
}