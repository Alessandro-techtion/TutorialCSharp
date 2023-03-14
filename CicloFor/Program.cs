namespace CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t Ciclo FOR");

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(i);
            }
            /*
             * La differenza tra il for e il while
             * - La variabile i la creiamo fuori deli ciclo
             * - Con il for andiamo a specificare una condizione 
             * - Non possiamo usare più condizioni con il for
             */
            string[] nomi = { "edo", "luca", "matteo", "simone" };
            foreach(string nome in nomi) //Per ciascun nome contenuto in nomi
            {
                Console.WriteLine("\n" + nome);
            }
        }
    }
}