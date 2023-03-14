using L_Ereditarietà;
using ParoleChiaviEreditarietà;

namespace LeInterfacce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tLe Interfacce");
            /*
             * LE INTERFACCE SONO COME DEI CONTRATTI CHE FACCIAMO FIRMARE ALLE NOSTRE CLASSI PER
             * ANDARE AD OTTENERE PROPRIETà E METODI AGGIUNTIVI CHE NON POTREBBERO OTTENERE DALLA CLASSE DISCENDENTE 
             *
             *Possiamo derivare da una sola classe, ma possiamo implementare quante Interfacc vogliamo
             *
             *IEquatable -> interfacce per verificare se due oggetti hanno proprietà uguali
             *per poter usare questa interfaccia bisogna usare il suo metodo
             *
             *public bool Equals(NomeClasse oggetto)
              {
                  return this.nome == studente.nome;
              }
             */
            Studente studente1 = new Studente("Alessandro", "Terzi", "5D");
            Insegnante insegnante1 = new Insegnante("Marco", "Antonio", "Informatica");
            Insegnante insegnante2 = new Insegnante("Anna", "Verdi", "Storia");

            Console.WriteLine(insegnante1.Equals(insegnante2));
            //Stiamo verificando che due insegnanti abbiano gli stessi parmentri
            Insegnante insegnante3 = new Insegnante("Marco", "Antonio", "Informatica");
            Console.WriteLine(insegnante1.Equals(insegnante3));
        }
    }
}