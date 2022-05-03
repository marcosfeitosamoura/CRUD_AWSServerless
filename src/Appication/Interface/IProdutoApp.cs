using Core_Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appication.Interface
{
    public interface IProdutoApp
    {
        Produto Cadastro(Produto produto);

        Produto Atualizacao(int id, Produto produto);
        Produto BuscaPorId(int produtoId);
        List<Produto> Lista();
        bool Exclui(int clienteId);
    }
}
