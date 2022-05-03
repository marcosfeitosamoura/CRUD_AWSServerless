using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Domain.Interface.Repository
{
    public interface IPedidoItemRepository : IBaseRepository<PedidoItem, int>
    {
        List<PedidoItem> GetByPedidoId(int pedidoId);
        bool DeletaByPedidoId(int pedidoId);
    }
}
