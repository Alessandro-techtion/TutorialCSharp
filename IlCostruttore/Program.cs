namespace IlCostruttore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tI Costruttore");
            /*
             * IL COSTRUTTORE VA AD AGGIUNGERE AUTOMATICAMENTE
             * GLI ATTRIBUTI DELL'OGGETTO
             * IN QUESTO CASO 
             * Persona persona1= new Persona();
             * Persona() è il costruttore di default
             * Il new si usa per richiamarlo
             */

            /*
            Persona persona1 = new Persona();
            persona1.nome = "Alessandro";
            persona1.cognome = "Terzi";
            persona1.età = 20;
            persona1.Saluta();
            Avendo creato un costruttore custom questo modo non funziona più
            */

            Persona persona1 = new Persona("Alessandro", "Terzi", 20);
            Persona persona2 = new Persona("Luca", "Rossi", 15);
            Persona persona3 = new Persona("Laura", "Bianchi", 32);
            Persona persona4 = new Persona("Davide", "Bernini", 0);

            //Il costrutto di overloading permette di avere più costruttori
            //a patto che abbiano le firme diverse


            Persona persona5 = new Persona();
            Persona persona6 = new Persona("Manghelli", 0);
        }
    }

    //Per le classi di solito si crea al di fuori della classe primaria
    //Ma nello stesso progetto
}