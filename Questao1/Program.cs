using System;
using Questao1.Model;
using Questao1.Controller;

namespace Questao1 {

    class Program{
        public static void Main(String [] args){
            Console.WriteLine("---------------Lista Telefônica---------------");
            Telefone telefone = new Telefone("Flávio", 1998, "Rua 1");
            Telefone tel = new Telefone("Rafaela", 1999, "Rua 10");
            Telefone tel1 = new Telefone("Rafainha", 1999, "Rua 11");
            telefone.telefone = "(19)99794-8146";
            tel.telefone = "(35)35123-8146";
            tel1.telefone = "(11)3456-8146";
            telefone.mostraInfo();
           // Console.WriteLine(telefone.getDDD());
            //Console.WriteLine(telefone.getOperadora());
            //Console.WriteLine(telefone.getNumero());


            List<Telefone> tels = new List<Telefone>();
            tels.Add(telefone);
            tels.Add(tel);
            tels.Add(tel1);
            OrdenaDDD or = new OrdenaDDD();
            or.ordenar(tels);
            foreach(Telefone t in or.getTelefones())
            {
                Console.WriteLine(t.getNumero());
            }
        }
    }
}