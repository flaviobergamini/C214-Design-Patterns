using System;
using Questao1.Model;
using Questao1.Controller;

namespace Questao1 {

    class Program{
        public static void Main(String [] args){
            Console.WriteLine("---------------Lista Telefônica---------------");
            
            Telefone telefone = new Telefone("Flávio", 1998, "Rua 1");
            Telefone telefone1 = new Telefone("Fernando", 1999, "Rua 10");
            Telefone telefone2 = new Telefone("Vânia", 1999, "Rua 11");

            telefone.telefone = "(19)9794-8146";
            telefone1.telefone = "(35)35123-8146";
            telefone2.telefone = "(11)3456-8146";


            List<Telefone> tels = new List<Telefone>();
            tels.Add(telefone);
            tels.Add(telefone1);
            tels.Add(telefone2);

            Console.WriteLine("---------Lista Original----------");
            foreach(Telefone t in tels){
                t.mostraInfo();
            }

            Console.WriteLine("\n-----------OddEvenSort - Numero-----------");
            Numero numero = new Numero(tels);
             foreach(Telefone t in numero.ordenar())
            {
                t.mostraInfo();
            }

            Console.WriteLine("\n-----------BubbleSort - DDD----------");
            DDD ddd = new DDD(tels);
             foreach(Telefone t in ddd.ordenar())
            {
                t.mostraInfo();
            } 
            
            Console.WriteLine("\n-----------QuickSort - Operadora-----------");
            Operadora operadora = new Operadora(tels);
             foreach(Telefone t in operadora.ordenar())
            {
                t.mostraInfo();
            }
        }
    }
}