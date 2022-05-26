using Questao1.Model;
using System;

namespace Questao1.View{

    public interface IOrdenacao
    {

        void ordenar(List<Telefone> telefones);
        List<Telefone> getTelefones();

    }
}