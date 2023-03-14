using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlPolimorfismo
{
    internal class Insegnante : Persona
    {
        public string materia;

        //Costruttore
        public Insegnante(string nome, string cognome, string materia) : base(nome, cognome)
        {
            this.materia = materia;
        }

        //Metodi
        //Con new stiamo conservando il Saluta() di Persona e quello di Insegnante
        //L'ovverride sovrascrive il metodo, mentre con il new possiamo scegliere quale usare
        public new void Saluta()
        {
            Console.WriteLine($"Buongiorno ragazzi, sono {nome} {cognome}");
        }
    }
}
