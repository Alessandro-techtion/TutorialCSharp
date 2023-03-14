using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IdentificatoreStatic
{
    internal class Persona //*Persona.numeroPersone
    {
        //Con private siamo vietando l'accesso esterno
        public string nome = "";
        public string cognome = "";
        public int età;

        //Aggiungiamo una proprietà static
        static public int numeroPersone =0; //Sarà condivisa
        //La proprietà non è legata all'ogetti bensì alla classe 
        //*

        
        public Persona(string nome, string cognome, int età)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.età = età;
            Persona.numeroPersone++;
            Console.WriteLine(Persona.numeroPersone);
        }

        //Metodi
        static public void Saluta(string nome)
        {
            //Console.WriteLine($"Ciao il mio nome è {nome} e il mio cognome è {this.cognome}"); //il this nome di questa persona è:
            //Essendo ora static non possiamo più usare il this
            Console.WriteLine($"Ciao sono {nome}");
        }

    }
}
