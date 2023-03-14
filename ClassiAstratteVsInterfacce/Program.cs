namespace ClassiAstratteVsInterfacce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tClassi Astratte Versus Interfacce");
            /*
             * LE CLASSI ASTRATTE SONO CLASSI CHE NON POSSONO ESSERE UTILIZZATE
             * PER LA CREAZIONE DI OGGETTI, NON POSSONO ESSERE ISTANZIATE DIRETTAMENTE
             * 
             * UNA CLASSE ASTRATTA INDICA UN CONCETTO
             * PER ESEMPIO UN VEICOOLO è UN CONCETTO
             * E UNA MACCHINA è UN VEICOLO
             * 
             * ANCHE IN QUESTO CASO PERSONA è UN CONCETTO, NOI NON ANDREMO MAI A IDENTIFICARE UNA PERSONA 
             * COME PERSONA, LA IDENTIFICHIAMO PER QUELLO CHE FA NELLA VITA OPPURE SE UN AMICO, FAMILIARE....
             * 
             * QUINDI SI SONO ENTRAMBI PERSONE, MA SONO COMUNQUE STUDENTI E INSEGNANTI
             * 
             * abstract nome_classe{}
             * 
             * Ora che è astratta non potremo più fare così
             * Persona persona1 = new Persona("Giorgio", "Vanni");
             * 
             * Una classe astratta possiamo usarla come base per implementare dei metodi,
             * ma non andremo mai a creare un oggetto di tipo Persona
             * Creremo un Avvocato, Meccanico, Ragagazzo, Ragazza, Bambina, Bambino, ecc...
             */

            Insegnante insegnante1 = new Insegnante("Anna", "Verdi", "Storia"); 
            Persona insegnante2 = new Insegnante("Marco", "Verdi", "Matematica"); //Polimorfismo

            /*
             * Quello che possiamo fare con Persona è creare dei metodi che dovranno però
             * Neccessariamente sovrascritte
             * 
             * Simile alle interfacce, ma le interfacce non sei obbligato a sovrascriverle
             */
            

            /*
             * QUINDI:
             * -LE CLASSI ASTRATTE POSSONO ESSERE SOLTANTO EREDITATE
             * -I METODI E LE PROPRIETà abstract DEVONO PER FORZA ESSERE SOVRASCRITTE
             */
        }
    }
}