using System;
using System.Collections;

namespace GliArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t ArrayList");
            /*
             * GLI ARRAYLIST SONO COME DELLE COLLEZIONI DI DATI CHE PERò 
             * NON HANNO NUMERO FISSO DI VALORI
             * -POSSIAMO AGGIUNGERE, TOGLIERE E MODIFICARE I VALORI
             * -POSSONO CONTENERE PIù TIPI DI VALORI
             */
            int[] ArrayNumeri = {1,2,3,4,5};

            //Creare un ArrayList
            ArrayList prova = new ArrayList();
            prova.Add(2);
            prova.Add("Prova");

            ArrayList prova2 = new ArrayList()
            {
                3,"prova3",true,4.5,null
            };

            //Leggere un ArrayList
            Console.WriteLine(prova2[3]);

            //Aggiungere un dato:
            prova.Add(true);
            prova.AddRange(ArrayNumeri); //Con AddRange possiamo aggiungere una collection
            Console.WriteLine(prova[6]); //Gli array vengono aggiunti come valore singoli

            /*          0   1     2 3 4  5    6 7
             *  prova = 2,"prova",1,2,3,true, 4,5
             */
            ArrayList parole = new ArrayList();
            parole.Add("Ciaoo");
            parole.Add("Come va?");
            parole.Add("Io bene");

            prova2.AddRange(parole); //Possiamo aggiungere anche altri arraylist
            Console.WriteLine(prova2[7]);


            //Insert, serve aggiungere all'indice scelto il valore
            //NON SOVASCRIVE IL DATO, LO SPOSTA DI UN INDICE
            //Prima prova[0] c'era il valore 2 ora il valore 2 sarà all'indice 1!!!
            prova.Insert(0, "Ho cambiato il valore all'indice 0");
            Console.WriteLine(prova[0]);
            prova[0] = "Ho sovrascritto il valore all'indice 0";
            Console.WriteLine(prova[0]);
            Console.WriteLine();

            //Eliminare dati da un'ArrayList
            ArrayList nuovoArrayListNumeri = new ArrayList() { "indice0","indice1", "indice2", "incide3","indice4","indice5","indice6" };
            nuovoArrayListNumeri.Remove("indice0");//Rimuove il valore indice0
            Console.WriteLine(nuovoArrayListNumeri[0]);
            nuovoArrayListNumeri.RemoveAt(1); //Rimuove il dato all'indice 1
            Console.WriteLine(nuovoArrayListNumeri[1]);
            nuovoArrayListNumeri.RemoveRange(0, 2); //Elimina i valori dall'indice 0 a 2
            Console.WriteLine(nuovoArrayListNumeri[0]);

            //Contains
            Console.WriteLine("Contiene il dato indice0? " + nuovoArrayListNumeri.Contains("indice0"));
            
            //Stampare l'ArrayList
            Console.WriteLine("\nStampa arrayList: ");
            foreach(object array in nuovoArrayListNumeri)
            {
                Console.WriteLine(array);
            };
            Console.WriteLine("\nSecondo modo per Stampa arrayList: ");
            foreach (var array in nuovoArrayListNumeri)
            {
                Console.WriteLine(array);
            };

            Console.WriteLine("\nTerzo modo per stampare un arrayList");
            for(int i=0; i<nuovoArrayListNumeri.Count; i++)
            {
                Console.WriteLine(nuovoArrayListNumeri[i]);
            }
        }
    }
}