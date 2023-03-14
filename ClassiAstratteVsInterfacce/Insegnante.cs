using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAstratteVsInterfacce
{
    internal class Insegnante : Persona
    {
        public string materia;

        public override int Età { get ; set; }

        public Insegnante(string nome, string cognome, string materia) : base(nome, cognome)
        {
            this.materia = materia;
        }

        

        public override void Saluta()
        {
            Console.WriteLine();
        }
    }
}
