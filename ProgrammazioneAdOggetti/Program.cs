namespace ProgrammazioneAdOggetti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tLa programmazzione ad Oggetti");
            /*
             * SONO AD OGGETTI TUTTI I LINGUAGGI CHE UTILIZZANO CLASSI E METODI
             * C# è UNO TRA QUESTI
             * - Lavorare con un linguaggio ad oggetti permette di fare molte più cose
             * - Avere un codice più ordinato e pulito
             * Ogni cosa che utilizziamo nel programma è un oggetto
             * 
             * Per esempio uno studente è una classe
             * e gli studenti sono oggetti della classe
             * 
             * La nostra classe sarà il file che abbiamo creato una sola volta
             * che descrive l'oggetto (quanto è alto, il nome, quanti anni ha...)
             * 
             * Ferrari Portofino (classe)
             * miniatora1 miniatura2 miniatura3 (oggetti)
             * Sono 3 istanze di Ferrari Portofino separati
             * 
             * I nostri oggetti sono istanze della nostra classe
             * 
             * OGNI OGGETTO PUò COMPIERE DELLE AZIONI
             */


            //ISTANZIARE UN OGGETTO
            Persona persona1 = new Persona();//Un oggetto di istanza Persona
          //Tipo    Nome        Costruttore

            persona1.nome = "Alessandro";
            Console.WriteLine(persona1.nome);
            persona1.Saluta();

            persona1.cognome = "Terzi";
            persona1.Saluta();
        }
    }


    //CREIAMO UNA NUOVA CLASSE
    class Persona
    {
        //Creiamo le proprietà di persona
        public string nome;
        public string cognome;


        public void Saluta()
        {
            //ABBIAMO UNA CLASSE PERSONA A CUI DAREMO UN NOME E CHE SARANNO
            //IN GRADO DI SALUTARE
            Console.WriteLine($"Ciao il mio nome è {nome} e il mio cognome è {this.cognome}");
            //Il this si riferisce a persona1, il this si riferisce alla variabile
            //Si usa in caso la firma di un metodo abbia una variabile chiamata uguale ad un'altra


        }
    }
}