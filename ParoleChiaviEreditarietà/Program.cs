using L_Ereditarietà;

namespace ParoleChiaviEreditarietà
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tParole Chiave Dell'Ereditarietà");
            /*
             * virtual, ovveride e sealed
             * 
             * L'override è la possibilità di sovrascrivere un metodo della classe da cui è ereditata
             * 
             * Il virtual concede al metodo di essere overraidato
             * 
             * sealed -> sigillo
             * 
             * Mettendo sealed le classi derivate da una classe non potranno overraidare il metodo Saluta()
             * 
             * Possiamo sigillare anche che le classi
             */
            Studente studente1 = new Studente("Alessandro", "Terzi", "5D");
            Insegnante insegnante1 = new Insegnante("Marco", "Lepri", "Informatica");
            studente1.Saluta();
            insegnante1.Saluta();
            InsegnanteBallo insegnanteBallo1 = new InsegnanteBallo("Sofia", "Itachi", "hip-hop", "Despacito");
            insegnanteBallo1.Saluta();  
        }
    }
}