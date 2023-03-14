namespace Cicli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t CICLI");
            //Loop = cliclo


            //While
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //Precondizione, prima verifica la condizione 
            //Dopo esegue il codice

            //Dowhile
            i= 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
            //Questo ciclo è post condizionale ovvero
            //Prima esegue il codice e dopo verifica la condizione
            //In caso la i = 6 il codice verrà eseguito una sola volta

            i=0;
            do
            {
                if (i == 3)
                {
                    Console.WriteLine("\nHeyyy il contatore è = a 3");
                }
                i++;
            }while (i < 5);
        }
    }
}