using System.Text.RegularExpressions;

namespace Questao1.Model{

    class Telefone : Pessoa
    {
        private int ddd;
        private int operadora;
        public string numero{get;}
        
        private static string regra = @"^\(([1-9]){2}\)(?:([0-9]{5})|([0-9]{4}))-([0-9]{4})$"; // regex para validar numero (xx)xxxxx-xxxx ou (xx)xxxx-xxxx
        public Telefone(string nome, int anoNasc, string endereco, string numero)
         : base(nome, anoNasc, endereco)
        {
            this.numero = numero;

        }

        public override void mostraInfo(){
            base.mostraInfo();
            Console.WriteLine($"Telefone: {this.numero}");
            Console.WriteLine("-----------------------------------");
        }
    }
}