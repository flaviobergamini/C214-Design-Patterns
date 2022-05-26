using Questao1.Controller;

namespace Questao1.Model{

    public class Numero : ListaTelefonica
    {
        public Numero(){
            this.iOrdenacao = new OrdenaNumero();
        } 
    }
}