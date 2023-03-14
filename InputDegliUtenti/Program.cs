using System;
namespace InputDegliUtenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t INPUT ");

            Console.WriteLine("Scrivi qualcosa ");
            string inputUtente = Console.ReadLine();
            Console.WriteLine("Hai scritto " + inputUtente);

            Console.WriteLine("\nInserisci un Numero da sommare");
            string numero1 = Console.ReadLine();
            Console.WriteLine("Inserisci un secondo numero");
            string numero2 = Console.ReadLine();

            int num1 = int.Parse(numero1);
            int num2 = int.Parse(numero2);
            int risultato = num1 + num2;
            Console.WriteLine("La somma è : " + risultato);

        }
    }
}