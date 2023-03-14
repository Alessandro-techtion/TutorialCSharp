using System.Reflection.Metadata;

namespace GliArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t Gli Array");
            /*
             * GLI ARRAY SONO UN MODO CONVENIENTE PER ANDARE A SALVARE
             * PIù DATI IN UNA SOLA VARIABILE
             */
            string nome1 = "Marco";
            string nome2 = "Simoe";
            string nome3 = "Andea";

            string[] nomi = { nome1, nome2, nome3 }; //Gli array hanno una dimensione fissa
            //Possiamo leggerli
            //Possiamo modificarli
            //Ma non possiamo toglierli

            string[] cognomi = new string[3]; //La differenza è che sopra abbiamo già inizializzato l'array
            //In questo caso stiamo dicendo che l'array conterrà 3 dati
            cognomi[0] = "Rossi";
            cognomi[1] = "Bianco";
            cognomi[2] = "Verdi";
            //0,1,2 Sono gli indici dell'Array
            Console.WriteLine(nomi[2] +" " + cognomi[2] +"\n");

            //Il foreach è perfetto per scorrere gli array
            foreach(string nome in nomi)
            {
                Console.WriteLine(nome);
            }

            int[] numeri = { 1, 2, 3, 4, 5};
            Console.WriteLine();
            foreach(int numero in numeri)
            {
                Console.WriteLine(numero);
            }

            bool[] bools = {true, false, false, false };
            Console.WriteLine();
            foreach(bool verofalso in bools)
            {
                Console.WriteLine(verofalso);
            }
        }
    }
}