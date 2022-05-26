using Questao1.View;

namespace Questao1.Model{
    public abstract class ListaTelefonica{
        protected IOrdenacao iOrdenacao;

        private void ordenar(List<Telefone> telefones) => this.iOrdenacao.ordenar(telefones);

        public List<Telefone> getTelefones(List<Telefone> telefones){
            this.ordenar(telefones);
            return this.iOrdenacao.getTelefones();
        }
    }
}