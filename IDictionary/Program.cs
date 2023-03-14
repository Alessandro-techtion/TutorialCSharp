namespace IDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tI Dictionary");
            /*
             * I Dictionary sono la stessa cosa delle HashTable 
             * se non fosse che richiedono la definizione specifica del tipo di
             * chiave e di valore
             * 
             */
            Dictionary<int, bool> prova = new Dictionary<int, bool>();
            Dictionary<string, string> prova2 = new Dictionary<string, string>()
            {
                {"Lombardia","Milano" },
                {"Liguria", "Genova" },
                {"Lazio", "Roma" },
                {"Piemonte", "Torino" }

            };

            prova.Add(1, true);
            prova2.Add("Sicilia", "Londra");
            prova2.Remove("Sicilia");

            //Stampare 

            foreach(var città in prova2)
            {
                Console.WriteLine(città);
            }
            int i = 0;
            //Stampare secondo modo
            foreach(KeyValuePair<string,string> città in prova2)
            {
                Console.WriteLine("Key= " + città.Key);
                
            }

        }
    }
}