using System;

namespace ArrayMultiDimensionali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t Array Multidimensionali");//Matrici Righe e Colonne
            /*
             * LE MATRICI SONO PIù ARRAY CON RIGHE E COLONNE
             *      1 2 3
             *      4 5 6
             *      7 8 9
             */
            //string[righe, colonne] codici = 

            string[,] codici = new string[3, 3]//3 righe e 3 colonne
            {   //righe
                {"1","2","3" },
                {"4","5","6" },
                {"7","8","9" }
            };
            Console.WriteLine(codici[0, 0]);
            Console.WriteLine(codici[1, 0]);
            Console.WriteLine(codici[0, 1]);
            codici[0, 1] = "100";
            Console.WriteLine(codici[0, 1]);

            //Stampare la matrice:
            foreach (string codice in codici)
            {
                Console.WriteLine(codice); //Ci stampa tutto, ma non possiamo accedere agli indici singoli
            }

            //Riga minore di codici.GetLength(della prima dimensione) 
            //La dimensione 0 corrisponderà alle righe, la dimensione 1 corrisponderà alle colonne
            //codici[3,3]
            Console.WriteLine();
            for (int riga = 0; riga < codici.GetLength(0); riga++)
            {
                Console.WriteLine("Sono in riga " + riga);
                for (int colonna = 0; colonna < codici.GetLength(1); colonna++)
                {
                    Console.WriteLine("Sono in colonna " + colonna);
                    Console.WriteLine("Valore: " + codici[riga, colonna]);
                    //Come potete vedere qui abbiamo l'accesso agli indici
                }
            }


            //Creiamo un Array a 3 dimensioni
            string[,,] Array3D = new string[2, 2, 2]
            { 
                {//1 dimensione lunga 2
                    {"010","011" }, //3 dimensione, lunghezza array
                    {"020","021"} //2 dimensione lunga 2
                },
                {
                    {"030","031" },//3 dimensione, lunghezza array
                    {"040","041" } //2 dimensione
                }//fine 1 dimensione lunga 2
            };

            Console.WriteLine();
            for (int dimensione1 = 0; dimensione1 < Array3D.GetLength(0); dimensione1++)
            {
                
                for (int dimensione2 = 0; dimensione2 < Array3D.GetLength(1); dimensione2++)
                {
                    for(int dimensione3 = 0; dimensione3 < Array3D.GetLength(2); dimensione3++)
                    {
                        Console.WriteLine($"Sono in dimensione1 {dimensione1} dimensione2 {dimensione2} dimensione3 {dimensione3} :");
                        
                        Console.WriteLine(Array3D[dimensione1,dimensione2,dimensione3]);
                    }
                    
                }
            }

            Console.WriteLine("\n");
            //OPPURE PER STAMPARLO SEMPLICEMENTE:
            foreach (string codice in Array3D)
            {
                Console.WriteLine("\n" + codice);
            }
        }
    }
}