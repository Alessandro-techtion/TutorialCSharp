namespace ArrayOMatriciIrregolari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t Array Irregolari");
            /*
             * Si trattano i Array contenenti altri Array di dimensioni differenti
             * int[][] arrayIrregolare = new int[4][]
             * Stiamo dicendo che questo array conterrà 4 elementi
             */

            //Primo modo
            int[][] array_irregolare = new int[4][];
            array_irregolare[0] = new int[] { 10, 20 };
            array_irregolare[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            array_irregolare[2] = new int[] { 100 };
            array_irregolare[3] = new int[] { -1, -2, -3, -4, -5 };

            //Secondo modo
            int[][] array_irregolare2 =
            {
                new int[] { 10, 20 },                   //0
                new int[] { 1, 2, 3 },                  //1
                new int[] { 100 },                      //2
                new int[] { -1, -2, -3, -4 },           //3
                new int[] { 11, 22, 33, 44 },           //4
                new int[] { 32, 98, 1, 57 }             //5
            };//Abbiamo inizializzato subito l'Array

            Console.WriteLine(array_irregolare2[5][1]);
            Console.WriteLine(array_irregolare2[4][3]);
            Console.WriteLine();

            //Per stampare tutto l'Array:
            for(int riga=0; riga<array_irregolare2.Length; riga++)
            {
                for(int colonna=0; colonna<array_irregolare2[riga].Length; colonna++)
                {
                    Console.WriteLine($" Riga {riga}, colonna {colonna}: valore {array_irregolare2[riga][colonna]}");
                }
            }
        }
    }
}