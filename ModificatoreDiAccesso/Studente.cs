using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificatoreDiAccesso
{
    internal class Studente : Persona
    {
        public string classe;
        public Studente(string nome, string cognome, string classe) : base(nome, cognome)
        {
            this.classe=classe;
        }

        public void prova()
        {
            base.Saluta();
            base.Respira();
        }
    }
}
