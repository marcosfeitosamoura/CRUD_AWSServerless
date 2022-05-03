using Core_Domain;
using Core_Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public class PedidoRepository : AbstractRepository<Pedido, int>, IPedidoRepository
    {
        private readonly GestaoContext _context;

        public PedidoRepository(GestaoContext context) : base(context)
        {
            _context = context;
        }
    }
}

