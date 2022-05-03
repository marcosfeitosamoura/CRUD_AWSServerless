using Appication.Interface;
using Core_Domain;
using Core_Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appication
{
    public class PedidoApp : IPedidoApp
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IPedidoItemRepository _pedidoItemRepository;
        public PedidoApp(IPedidoRepository pedidoRepository, IPedidoItemRepository pedidoItemRepository)
        {
            _pedidoRepository = pedidoRepository;
            _pedidoItemRepository = pedidoItemRepository;
        }

        public Pedido Atualizacao(int id, Pedido pedido)
        {
            Pedido pedidoInserido = _pedidoRepository.GetById(id);

            if (pedido.PedidoItems != null && pedido.PedidoItems.Count > 0)
            {
                _pedidoItemRepository.DeletaByPedidoId(id);

                pedido.PedidoItems.ForEach((pedidoItem) =>
                {
                    pedidoItem.PedidoId = pedidoInserido.Id;
                    _pedidoItemRepository.Salvar(pedidoItem);
                });

                pedidoInserido.QuantidadeItens = pedido.PedidoItems.Count;
                pedidoInserido.ValorTotal = pedido.PedidoItems.Sum(pdi => pdi.ValorTotal);

                _pedidoRepository.Atualizar(pedidoInserido);
            }

            pedidoInserido.PedidoItems = _pedidoItemRepository.GetByPedidoId(pedidoInserido.Id);
            return pedidoInserido;
        }

        public Pedido BuscaPorId(int pedidoId)
        {
            Pedido pedido = _pedidoRepository.GetById(pedidoId);

            if(pedido != null)
                pedido.PedidoItems = _pedidoItemRepository.GetByPedidoId(pedidoId);

            return pedido;
        }

        public Pedido Cadastro(Pedido pedido)
        {
            pedido.DataCadastro = DateTime.Now;

            Pedido pedidoInserido = _pedidoRepository.Salvar(pedido);

            if(pedido.PedidoItems != null && pedido.PedidoItems.Count > 0)
            {
                pedido.PedidoItems.ForEach((pedidoItem) =>
                {
                    pedidoItem.PedidoId = pedidoInserido.Id;
                    _pedidoItemRepository.Salvar(pedidoItem);
                });

                pedidoInserido.QuantidadeItens = pedido.PedidoItems.Count;
                pedidoInserido.ValorTotal = pedido.PedidoItems.Sum(pdi => pdi.ValorTotal);

                _pedidoRepository.Atualizar(pedidoInserido);
            }

            return pedidoInserido;
        }

        public bool Exclui(int pedidoId)
        {
            _pedidoItemRepository.DeletaByPedidoId(pedidoId);
            _pedidoRepository.Deletar(pedidoId);
            
            return true;
        }

        public List<Pedido> Lista()
        {
            List<Pedido> pedidos = _pedidoRepository.GetAll().ToList();

            pedidos.ForEach((pedido) =>
            {
                pedido.PedidoItems = _pedidoItemRepository.GetByPedidoId(pedido.Id);
            });

            return pedidos;
        }
    }
}
