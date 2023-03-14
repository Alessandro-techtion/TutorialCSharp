namespace L_Ereditarietà
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tL'Erededitarietà della classe");
            /*
             * L'ereditarietà è il fatto che una classe possa essere derivata
             * da un'altra classe ed ereditare proprietà ed metodi
             * esempio genitori -> figli
             * 
             * per far ereditare una classe:
             * 
             * nome_classe : nome_classe da cui deriva
             */

            Studente studente1 = new Studente("Alessandro", "Teri", "5D");
            Insegnante insegnante1 = new Insegnante("Marco", "Andreini", "Informatica");

            studente1.Saluta();
            insegnante1.Saluta();
        }
    }
}