using Core_Domain;
using Core_Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public class ProdutoRepository : AbstractRepository<Produto, int>, IProdutoRepository
    {
        private readonly GestaoContext _context;

        public ProdutoRepository(GestaoContext context) : base(context)
        {
            _context = context;
        }
    }
}