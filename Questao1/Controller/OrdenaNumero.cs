using Questao1.Model;
using Questao1.View;

namespace Questao1.Controller{
    public class OrdenaNumero : IOrdenacao
    {
        private List<Telefone> telefones = new List<Telefone>();
        public List<Telefone> getTelefones()
        {
            return telefones;
        }

        public void ordenar(List<Telefone> telefones)
        {
            bool ordenado = false;
            int tamanho = telefones.Count();
            while (!ordenado)
            {
                ordenado = true;
                // odd-even
                for (int i = 1; i < tamanho - 1; i += 2)
                {
                    if (telefones[i].getNumero() > telefones[i + 1].getNumero())
                    {
                        Telefone tel = telefones[i];
                        telefones[i] = telefones[i + 1];
                        telefones[i + 1] = tel;

                        ordenado = false;
                    }
                }

                // even-odd
                for (int i = 0; i < tamanho - 1; i += 2)
                {
                    if (telefones[i].getNumero() > telefones[i + 1].getNumero())
                    {
                        Telefone tel = telefones[i];
                        telefones[i] = telefones[i + 1];
                        telefones[i + 1] = tel;

                        ordenado = false;
                    }
                }
            }
            this.telefones = telefones;
        }
    }
}