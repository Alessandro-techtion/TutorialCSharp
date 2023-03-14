namespace IValoriNulli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tI Valori Nullaeabil");
            /*
             * Ci possono essere dati che non hanno dei valori
             * 
             */
            
            //int prova2 = null;
            
            int? prova = null;
            //Il punto di ? serve per avvertire che la variabile potrebbe essere null

            bool? prova2 = new bool?();

            bool? isMaschio = null;
            if (isMaschio == true) Console.WriteLine("Sei maschio");
            else if (isMaschio == false) Console.WriteLine("Sei femmina");
            else Console.WriteLine("Genere non spcificato");

            //Casting
            int? numero = 2;
            int numero2 = (int)numero;


            //Coalescing
            int prova3 = prova ?? 5;
            //Se prova è null il valore di prova 3 è 5
        }
    }
}