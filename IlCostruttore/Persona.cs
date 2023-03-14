using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlCostruttore
{
    class Persona
    {
        public string nome="";
        public string cognome="";
        public int età;

        //Creazione di un costruttore
        public Persona(string nome,string cognome,int età) //è letteralmente un metodo con dei parametri
        {
            //nome = nome; Questra istruzione manda in confusione il programma perchè abbiamo
            //2 variabili di nome nome, una della classe Persona e una nel costruttore
            //Perciò o cambiamo il nome di una delle 2 oppure possiamo usare il this.
            
            this.nome = nome;
            /*
             * this permette di dire che devi usare la variabile nome che fa 
             * riferimento alla classe this (riferita a Persona)
             */
            this.cognome = cognome;
            this.età = età;
        }

        //Overloading costructur
        public Persona(string cognome, int età)
        {
            this.cognome = cognome;
            this.età = età;
        }

        public Persona(int età)
        {
            this.età = età;
        }

        public Persona()
        {

        }

        //Metodi
        public void Saluta()
        {
            Console.WriteLine($"Ciao il mio nome è {nome} e il mio cognome è {this.cognome}");
        }
    }
}
