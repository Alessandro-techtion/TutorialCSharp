namespace IlPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tIl Polimorfismo");
            /*
             * IL POLIMORFISMO è UNO DEI PRINCIPALI FONDAMENTALI DELLA PROGRAMMAZIONE AD OGGETTO
             * ED è LA CAPACITà DEGLI OGGETTI DI AVERE PIù FORME
             * 
             * Regola del polimorfismo
             * 1) Ci permette di utilizzare su una classe la classe da cui deriva come tipo di datoù
             * 
             * Il polimorfismo è la capacità di un oggetto di utilizzare sia la propria classe 
             * che la classe da cui deriva 
             */

            var persone = new List<Persona> //Abbiamo creato una variabile generica che contiene una lista persona
            {
                //Uno studente è anche una persona
                new Studente("Luca", "Rossi","3D"),
                new Insegnante("Camilla", "Verdi", "Matematica"),
            };

            foreach (Persona persona in persone)
            {
                persona.Saluta();
                //In questo caso l'insegnante Camilla, Verdi Saluterà usando il metodo di Saluta()
            }

            //In base a come li definiamo avranno un tipo diverso del metodo Saluta()
            Console.WriteLine();
            Insegnante insegnante1 = new Insegnante("Alessandro", "Terzi", "Informatica");
            Persona insegnante2 = new Insegnante("Martina", "Londi", "Storia");
            insegnante1.Saluta();
            insegnante2.Saluta();
        }
    }
}