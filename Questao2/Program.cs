using Questao2.Model;

namespace Questao2{
   
    class Program{
        public static void Main(String [] args){

            Palavras palavras = new Palavras();

            ContaPalavras cp1 = new ContaPalavras(1);
            ContaPalavras cp2 = new ContaPalavras(2);
            ContaPalavras cp3 = new ContaPalavras(3);

            palavras.registraContador(cp1);
            palavras.registraContador(cp2);
            palavras.registraContador(cp3);

            Console.WriteLine(palavras.getContadores().Count());

            palavras.setNovaFrase("O Rato roeu a roupa do rei de Roma");
            
            palavras.removeContador(cp3);
            palavras.setNovaFrase("O céu pode ser o limite para o corpo, para a mente temos o universo ainda. Só festa!!!");
            
        }
    } 
}