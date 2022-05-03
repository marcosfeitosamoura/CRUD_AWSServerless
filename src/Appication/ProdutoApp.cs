using Appication.Interface;
using Core_Domain;
using Core_Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appication
{
    public class ProdutoApp : IProdutoApp
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoApp(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto Cadastro(Produto produto)
        {
            produto.DataCadastro = DateTime.Now;
            _produtoRepository.Salvar(produto);

            return produto;
        }

        public Produto Atualizacao(int id, Produto produto)
        {
            Produto produtoAtualiza = _produtoRepository.GetById(id);

            produtoAtualiza.Nome = produto.Nome;
            produtoAtualiza.Valor = produto.Valor;
            produtoAtualiza.Quantidade = produto.Quantidade;
            produtoAtualiza.Status = produto.Status;

            _produtoRepository.Atualizar(produtoAtualiza);

            return produtoAtualiza;
        }

        public Produto BuscaPorId(int produtoId)
        {
            return _produtoRepository.GetById(produtoId);
        }

        public List<Produto> Lista()
        {
            return _produtoRepository.GetAll().ToList();
        }

        public bool Exclui(int produtoId)
        {
            try
            {
                Produto produto = _produtoRepository.GetById(produtoId);

                if (produto == null)
                    return false;

                _produtoRepository.Deletar(produtoId);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
