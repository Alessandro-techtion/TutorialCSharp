using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IlPolimorfismo
{
    internal class Studente : Persona
    {
        public string classe;


        public Studente(string nome, string cognome, string classe) : base(nome, cognome)
        {
            this.classe = classe;
        }

        public override void Saluta()
        {
            Console.WriteLine($"Buongiorno prof, sono {nome} {cognome}");
        }
    }
}
