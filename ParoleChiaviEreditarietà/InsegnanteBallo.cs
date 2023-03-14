using L_Ereditarietà;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParoleChiaviEreditarietà
{
    internal class InsegnanteBallo : Insegnante
    {
        public string canzonePreferita;
        
        
        //Costruttore
        public InsegnanteBallo(string nome, string cognome, string materia, string canzonePreferita) : base(nome, cognome, materia)
        {
            this.canzonePreferita = canzonePreferita;
        }

        public override void Saluta()
        {
            Console.WriteLine("Buongiorno ragazzi, ora iniziamo a ballare, DANCE, DANCE, DANCE!!!!");
            
        }
    }
}
