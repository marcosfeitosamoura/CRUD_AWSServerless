using Core_Domain;
using Core_Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repository
{
    public class PedidoItemRepository : AbstractRepository<PedidoItem, int>, IPedidoItemRepository
    {
        private readonly GestaoContext _context;

        public PedidoItemRepository(GestaoContext context) : base(context)
        {
            _context = context;
        }

        public bool DeletaByPedidoId(int pedidoId)
        {
            List<PedidoItem> pedidoItems = _context.PedidoItem.Where(pdi => pdi.PedidoId == pedidoId).ToList();

            pedidoItems.ForEach((pedido) => { _context.PedidoItem.Remove(pedido); });
            return true;
        }

        public List<PedidoItem> GetByPedidoId(int pedidoId)
        {
            return _context.PedidoItem.Where(pdi => pdi.PedidoId == pedidoId).ToList();
        }
    }
}
