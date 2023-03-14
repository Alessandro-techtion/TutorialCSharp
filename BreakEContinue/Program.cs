namespace BreakEContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t Break and Continue");
            for (int i = 0; i < 5; i++)
            {
                if(i == 3) break;
                Console.WriteLine(i);
            }
            for(int i = 0; i < 5; i++)
            {
                if (i == 4) continue; //Quando la i è = 4 ritorna nel ciclo e salta le istruzioni sotto
                Console.WriteLine("La i è uguale a 4");
                
            }

            
        }
    }
}