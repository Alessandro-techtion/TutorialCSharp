using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratteVsInterfacce
{
    internal class Studente : Persona
    {
        public string classe;
        
        //Abbiamo implementato il get e il set della proprietà Età
        public override int Età { get; set; }
        public Studente(string nome, string cognome, string classe) : base(nome,cognome)
        {
            this.classe = classe;
        }


        public override void Saluta()
        {
            Console.WriteLine($"Buongiorno prof, sono {nome} {cognome}");    
        }

        
    }
}
