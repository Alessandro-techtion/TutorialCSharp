using System.IO.Pipes;

namespace LeQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tLe Queue");
            /*
             * Le queue sono il contrario degli stack 
             * -Negli stack pescavamo i dati partendo dall'ultimo inserito in poi
             * -Nelle queue peschiamo i dati partendo dal primo inserito (FIFO)
             * First Insert First Out
             * Pensiamo alle queue come una coda
             * 
             */

            //Creare una queue:
            Queue<string> persone = new Queue<string>();
            persone.Enqueue("Edoardo");
            persone.Enqueue("Anna");
            persone.Enqueue("Lucia");
            persone.Enqueue("Mattia");
            Console.WriteLine(persone.Peek());
            
            //Rimuovere persone in coda
            persone.Dequeue(); //In questo caso sarà Edoardo
            
            //Pulire la queue
            //persone.Clear();

            //Stampare la nostra coda
            foreach (string persona in persone) Console.WriteLine("Persone in coda: " + persona);

            Console.WriteLine();
            //Rimuovere le persone in coda
            while(persone.Count > 0)
            {
                Console.WriteLine(persone.Dequeue());
            }
            
        }
    }
}