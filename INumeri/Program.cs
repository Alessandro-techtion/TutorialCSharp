using System;
namespace INumeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n \n \n I NUMERI:");
            //Operatori, equazioni, increment, decrement, assegnazione, str
            //Metodi math: abs,pow,min,max,sqrt

            int a = 10;
            int b = 5;
            int risultato = a + b;
            Console.WriteLine("La somma è " + risultato);
            risultato = a * b;
            Console.WriteLine("La moltiplicazione è " + risultato);
            risultato = a - b;
            Console.WriteLine("La sottrazione è " + risultato);
            risultato = a / b;
            Console.WriteLine("La divisione è " + risultato);

            risultato = a % b;
            Console.WriteLine("Il modulo è " + risultato);
            /*
             * il %
             * divide i due numeri ma tiene conto solo il resto
             *  5 % 2 = 1
             *  6 % 2 = 0
             */

            //Operatori Increment, Decrement
            ++a;
            --b;
            Console.WriteLine("\n" + a);
            Console.WriteLine(b);

            //Assegnazione
            a = a + 10;
            Console.WriteLine("\n" + a);
            a += 5;
            Console.WriteLine(a);

            //str + int

            string stringa1 = "5";
            string stringa2 = "5";
            Console.WriteLine("\n" + stringa1 + stringa2);
            
            Console.WriteLine("\n" + Int32.Parse(stringa1 + stringa2) + "\n"); //Prende 55 come int
            Console.WriteLine(Int32.Parse(stringa1) + Int32.Parse(stringa2));

            //Metodi Math

            Console.WriteLine("\n Metodo Abs Math: " + Math.Abs(-50));
            Console.WriteLine("\n Metodo Min Math: " + Math.Min(5, 10));
            Console.WriteLine("\n Metodo Max Math: " + Math.Max(5, 10));
            Console.WriteLine("\n Metodo Pow Math: " + Math.Pow(3,2));
            Console.WriteLine("\n Metodo Sqrt Math: " + Math.Sqrt(16));


        }
    }
}