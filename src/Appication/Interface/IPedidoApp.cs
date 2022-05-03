using Core_Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appication.Interface
{
    public interface IPedidoApp
    {
        Pedido Cadastro(Pedido pedido);

        Pedido Atualizacao(int id, Pedido pedido);
        Pedido BuscaPorId(int pedidoId);
        List<Pedido> Lista();
        bool Exclui(int pedidoId);
    }
}
