using Questao2.View;

namespace Questao2.Model{

    public class Palavras : IPalavras
    {

        private string _frase = "";

        public string frase{
            get{return this._frase;}
            set{
                Console.WriteLine("------------Nova Frase para análise------------");
                this._frase = frase;
                this.notificaContadores();
            }
        }

	    private List<ContaPalavras> contadores;

        public Palavras(){
            this.contadores = new List<ContaPalavras>();
        }

        public void registraContador(ContaPalavras contaPalavras)
        {
            this.contadores.Add(contaPalavras);
        }

        public void removeContador(ContaPalavras contaPalavras)
        {
            if(this.contadores.Contains(contaPalavras)){
                this.contadores.Remove(contaPalavras);
            }
        }

          public void notificaContadores()
        {
            foreach(ContaPalavras cp in this.contadores){
                
            }
        }
    }
}