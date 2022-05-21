using System;
using Questao1.Model;

namespace Questao1 {

    class Program{
        public static void Main(String [] args){
            Console.WriteLine("---------------Lista Telefônica---------------");
            Telefone telefone = new Telefone("Flávio", 1998, "Rua 1", "(19)99794-8146");
            telefone.mostraInfo();

        }
    }
}