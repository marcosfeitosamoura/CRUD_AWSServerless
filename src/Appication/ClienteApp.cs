using Appication.Interface;
using Core_Domain;
using Core_Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appication
{
    public class ClienteApp : IClienteApp
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteApp(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Cadastro(Cliente cliente)
        {
            cliente.DataCadastro = DateTime.Now;
            _clienteRepository.Salvar(cliente);

            return cliente;
        }

        public Cliente Atualizacao(int id, Cliente cliente)
        {
            Cliente cliAtualiza = _clienteRepository.GetById(id);

            cliAtualiza.Nome = cliente.Nome;
            cliAtualiza.Email = cliente.Email;
            cliAtualiza.Status = cliente.Status;
            cliAtualiza.Logradouro = cliente.Logradouro;
            cliAtualiza.Numero = cliente.Numero;
            cliAtualiza.Bairro = cliente.Bairro;
            cliAtualiza.Cidade = cliente.Cidade;
            cliAtualiza.Uf = cliente.Uf;
            cliAtualiza.Complemento = cliente.Complemento;

            _clienteRepository.Atualizar(cliAtualiza);

            return cliAtualiza;
        }

        public Cliente BuscaPorId(int clienteId)
        {

            return _clienteRepository.GetById(clienteId);
        }

        public List<Cliente> Lista()
        {
            return _clienteRepository.GetAll().ToList();
        }

        public bool Exclui(int clienteId)
        {
            try
            {
                Cliente cliente = _clienteRepository.GetById(clienteId);

                if (cliente == null)
                    return false;

                _clienteRepository.Deletar(clienteId);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
