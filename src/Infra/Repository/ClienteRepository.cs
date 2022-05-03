
using Core_Domain;
using Core_Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public class ClienteRepository : AbstractRepository<Cliente, int>, IClienteRepository
    {
        private readonly GestaoContext _context;

        public ClienteRepository(GestaoContext context) : base(context)
        {
            _context = context;
        }
    }
}
