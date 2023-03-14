namespace Condizioni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t \t \t IF - ELSE - ELSE IF");
            if (5 < 6)
            {
                Console.WriteLine("\nCondizione Verificata");

            }
            else
            {
                Console.WriteLine("\nCondizione Non Verificata");
            }

            int numero = 10;
            if(numero > 5 && numero <= 10)
            {
                Console.WriteLine("Il numero è maggiore di 5 ma minore di 10");
            }
            else
            {
                Console.WriteLine("Il numero è minore di 5 o è maggiore di 10");
            }

            //ELSE IF
            numero = 5;
            if (numero > 10)
            {
                Console.WriteLine("Maggiore di 10");
            }else if(numero > 0)
            {
                Console.WriteLine("Maggiore di 0");
            }
            else
            {
                Console.WriteLine("Numero negativo");
            }

            //IF ANNIDATI
            numero = 20;
            if(numero > 10)
            {
                Console.WriteLine("\nNumero maggiore di 10");
                if(numero % 2 ==0)
                {
                    Console.WriteLine("Numero pari");
                }
                else
                {
                    Console.WriteLine("Numero dispari");
                }
            }
            else
            {
                Console.WriteLine("\nNumero minore di 10");
            }

            string parola = "Ciao";
            if(parola == "Ciao")
            {
                Console.WriteLine("Ricambio il saluto");
            }
            else
            {
                Console.WriteLine("Ciao!");
            }
        }   
    }
}