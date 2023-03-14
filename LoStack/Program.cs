namespace LoStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tLo Stack");
            /*
             * Gli stack --> Staccare gli elementi (minecraft)
             * Mettere uno sopra l'altro
             * Stack utilizza il metodo LIFO (Last In First Out)
             *                       l'ultimo elemento che entra è il primo ad uscire
             * Stack è un tipo di collection che si basa sullo stacking
             * sulla messa uno sopra l'altro degli elementi e quello che è sopra
             * viene poi rimosso per primo
             */
            
            //Creare uno stack
            Stack<int> inventario = new Stack<int>();

            //Aggiungere gli elementi
            inventario.Push(10);
            inventario.Push(20);
            inventario.Push(30);
            inventario.Push(40);
            inventario.Push(50);
            inventario.Push(60);

            //Leggere il picco (in cima)
            Console.WriteLine(inventario.Peek());

            //Eliminare un elemento
            inventario.Pop(); //Toglie il primo partendo dal basso ovvero 60

            //Pulisc lo stack
            inventario.Clear();

            if(inventario.Count > 0)
            {
                Console.WriteLine(inventario.Peek());
            }
            else
            {
                Console.WriteLine("Inventario vuoto");
            }

            Stack<int> inventario2 = new Stack<int>();
            inventario2.Push(1);
            inventario2.Push(2);
            inventario2.Push(3);
            inventario2.Push(4);
            inventario2.Push(5);

            //Stampare tutto l'Inventario
            foreach(int items in inventario2)
            {
                Console.WriteLine("Gli item in inventario 2 sono: " + items);
            }; 

        }
    }
}