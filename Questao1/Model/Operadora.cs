using Questao1.Controller;

namespace Questao1.Model{

    public class Operadora : ListaTelefonica
    {
        public Operadora(){
            this.iOrdenacao = new OrdenaOperadora();
        } 
    }
}