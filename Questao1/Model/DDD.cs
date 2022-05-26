using Questao1.Controller;

namespace Questao1.Model{

    public class DDD : ListaTelefonica
    {
        public DDD(){
            this.iOrdenacao = new OrdenaDDD();
        } 
    }
}