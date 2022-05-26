using Questao1.View;

namespace Questao1.Model{
    class ListaTelefonica{
        protected IOrdenacao iOrdenacao;

        private void ordenar(List<Telefone> telefones) => iOrdenacao.ordenar(telefones);

        public List<Telefone> getTelefones(List<Telefone> telefones){
            this.ordenar(telefones);
            return iOrdenacao.getTelefones();
        }
    }
}