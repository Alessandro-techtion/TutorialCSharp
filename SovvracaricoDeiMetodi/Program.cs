namespace SovvracaricoDeiMetodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Il metodo di overloading è la possibilità
            //di andare a creare più metodi con lo stesso nome
            //andando però a cambiare la signature o firma
            //che è l'insieme dei parametri
            Console.WriteLine("\t\t\t Sovraccarico dei metodi");
            
            int risultato = FaiSomma(10, 20);
            Console.WriteLine("Il risultato della somma è:" + risultato);
            
            risultato=FaiSomma(50,20.51);
            Console.WriteLine("\nIl risultato della somma è:" + risultato);

            double result;
            result = FaiSomma(5.5, 10.5);
            Console.WriteLine("\nIl risultato della somma è:" + result);
        }

        //METODI
        static int FaiSomma(int numero1, int numero2)
        {
            int retvalue;
            retvalue = numero1 + numero2;
            return retvalue;
        }

        static int FaiSomma(int numero1, double numero2)
        {
            int retvalue;
            retvalue = numero1 + (int)numero2;
            return retvalue;
        }

        static double FaiSomma(double numero1, double numero2)
        {
            double retvalue;
            retvalue = numero1 + numero2;
            return retvalue;
        }


    }
}