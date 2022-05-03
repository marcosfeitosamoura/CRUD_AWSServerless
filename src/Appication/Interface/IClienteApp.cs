using Core_Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appication.Interface
{
    public interface IClienteApp
    {
        Cliente Cadastro(Cliente cliente);

        Cliente Atualizacao(int id, Cliente cliente);
        Cliente BuscaPorId(int clienteId);
        List<Cliente> Lista();
        bool Exclui(int clienteId);
    }
}
