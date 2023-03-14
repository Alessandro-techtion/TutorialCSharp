using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Ereditarietà
{

    internal sealed class Studente : Persona, IEquatable<Studente>
    {

        public string classe;

        //Costruttore
        public Studente(string nome, string cognome, string classe) : base(nome, cognome)
        {

            this.classe = classe;
        }



        //Metodi
        public sealed override void Saluta()
        {//Mettendo sealed le classi derivate da Studente non potranno overraidare il metodo Saluta()
            Console.WriteLine("Buongiorno prof");
        }
        public void Studia()
        {

        }

        public bool Equals(Studente studente)
        {
            return this.nome == studente.nome;

        }
    }
}
