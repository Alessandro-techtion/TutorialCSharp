namespace IDataTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tI Data Time");
            /*https://www.c-sharpcorner.com/article/datetime-in-c-sharp/
             * Sono essenzialmente le date
             */

            DateTime data = new DateTime();
            Console.WriteLine(data);

            DateTime data2 = new DateTime(2021,12,20, 12,39,40);
            Console.WriteLine(data2);

            Console.WriteLine();

            //Stampa la data di oggi
            DateTime dataOra = DateTime.Today;
            Console.WriteLine(dataOra);

            //Data di oggi e l'orario
            DateTime dataOraDiOggi = DateTime.Now;
            Console.WriteLine(dataOraDiOggi);

            //Prende la data di oggi e aggiunge 11 giorni 
            DateTime data3= DateTime.Now;
            Console.WriteLine("\n"+data3.AddDays(11));

            //Sottra la data2 a data3
            Console.WriteLine(data3.Subtract(data2));


            //FORMATTAZIONE
            Console.WriteLine(data3.ToString("D"));
        }
    }
}