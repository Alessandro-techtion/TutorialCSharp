namespace OperatoriLogici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t \t Operatori Logici");
            //comparazione : < > <= >= == !=
            //logici: && || !

            Console.WriteLine(5 < 6); //true
            Console.WriteLine(5 == 6); //false
            Console.WriteLine(5 != 6); //true

            Console.WriteLine(5 > 3 && 5 < 6); //true
            Console.WriteLine(5 > 10 || 5 < 6); //true
            Console.WriteLine(5 > 10 && 5 < 4); //false

            bool isOnline = true; 
            Console.WriteLine(!isOnline); //false
            //il ! va dire il contrario

            int tagliaDisponibile = 39;
            string coloreDisponibile = "bianco";

            Console.WriteLine(tagliaDisponibile == 39 && (coloreDisponibile == "bianco" || coloreDisponibile == "nero")); //true
        }
    }
}