using Questao1.Model;
using Questao1.View;

namespace Questao1.Controller{
    public class OrdenaOperadora : IOrdenacao
    {
        private static List<Telefone> listaTelefones = new List<Telefone>();

        public OrdenaOperadora(){
            listaTelefones.Clear();
        }

        public List<Telefone> getTelefones()
        {
            return listaTelefones;
        }

        public void ordenar(List<Telefone> telefones)
        {
            int inicio = 0;
            int fim = telefones.Count() - 1;

            quickSort(telefones, inicio, fim);
        }

        private static void quickSort(List<Telefone> telefones, int inicio, int tamanho)
        {
            if (inicio < tamanho)
            {
                Telefone tel = telefones[inicio];
                int i = inicio + 1;
                int f = tamanho;

                while (i <= f)
                {
                    if (telefones[i].getOperadora() <= tel.getOperadora())
                    {
                        i++;
                    }
                    else if (tel.getOperadora() < telefones[f].getOperadora())
                    {
                        f--;
                    }
                    else
                    {
                        Telefone troca = telefones[i];
                        telefones[i] = telefones[f];
                        telefones[f] = troca;
                        i++;
                        f--;
                    }
                }

                telefones[inicio] = telefones[f];
                telefones[f] = tel;

                quickSort(telefones, inicio, f - 1);
                quickSort(telefones, f + 1, tamanho);
            }
            listaTelefones = telefones;
        }

    }
}